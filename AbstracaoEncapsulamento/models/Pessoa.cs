// Importa o namespace System, necessário para usar classes básicas como Console.
// Isso permite escrever no console, que é usado no método Apresentar().
using System;

// Define o namespace do projeto, agrupando classes relacionadas.
// Isso organiza o código e evita conflitos de nomes com outras bibliotecas.
namespace AbstracaoEncapsulamento.models
{
    // Classe Pessoa: representa uma abstração de uma pessoa com nome e idade.
    // Abstração significa focar no essencial (nome e idade), ignorando detalhes irrelevantes.
    // Essa classe serve como base para herança, permitindo que subclasses como Aluno e Professor herdem seus atributos e métodos.
    // Ela demonstra encapsulamento através de propriedades públicas, mas poderia ser expandida para privados com getters/setters.
    public class Pessoa
    {
        // Propriedade Nome: armazena o nome da pessoa.
        // Public permite acesso direto de fora da classe, facilitando a abstração e uso simples.
        // Em POO, propriedades públicas são comuns para dados não sensíveis, mas encapsulamento poderia torná-las privadas com métodos de acesso.
        public string Nome { get; set; }

        // Propriedade Idade: armazena a idade da pessoa.
        // Similar ao Nome, é pública para acesso direto, parte da abstração da classe Pessoa.
        // Isso permite definir idade facilmente, como visto em Program.cs.
        public int Idade { get; set; }

        // Construtor padrão (sem parâmetros): permite criar uma instância sem inicializar nada.
        // Útil para flexibilidade, como em Aluno a2 = new Aluno();, onde atributos são definidos depois.
        // Em herança, subclasses podem chamar construtores base ou não.
        public Pessoa()
        {
        }

        // Construtor com parâmetro (nome): inicializa o nome ao criar a instância.
        // Isso demonstra sobrecarga de construtores, permitindo criação rápida com dados essenciais.
        // Chama implicitamente o construtor padrão, mas define Nome diretamente.
        // Esse construtor é usado em Program.cs para Pessoa p1 = new Pessoa("Lucas");.
        public Pessoa(string nome)
        {
            // Atribui o parâmetro 'nome' à propriedade Nome.
            // Isso encapsula a lógica de inicialização, garantindo que o nome seja definido corretamente.
            Nome = nome;
        }

        // Método Apresentar(): exibe uma mensagem de apresentação no console.
        // É virtual, permitindo sobrescrita em subclasses (polimorfismo), como em Aluno e Professor.
        // Isso demonstra abstração: o método encapsula o comportamento de apresentação, sem expor detalhes internos.
        // Chamado em Program.cs para mostrar como subclasses alteram o comportamento.
        public virtual void Apresentar()
        {
            // Escreve no console uma mensagem formatada com Nome e Idade.
            // Usa interpolação de strings ($"") para inserir valores dinamicamente.
            // Isso é associado à abstração, pois abstrai a exibição de detalhes pessoais.
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
