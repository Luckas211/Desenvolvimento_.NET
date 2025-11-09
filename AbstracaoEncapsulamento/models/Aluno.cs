// Importa o namespace System, necessário para usar Console no método Apresentar().
// Isso permite escrever mensagens no console, associado ao comportamento de apresentação.
using System;

// Define o namespace do projeto, agrupando classes relacionadas.
// Isso mantém organização e evita conflitos de nomes.
namespace AbstracaoEncapsulamento.models
{
    // Classe Aluno: herda de Pessoa, adicionando propriedade Nota e sobrescrevendo Apresentar().
    // Herança permite reutilizar Nome e Idade de Pessoa, focando em aspectos específicos de um aluno.
    // Isso demonstra polimorfismo: Apresentar() se comporta diferentemente em Aluno vs. Pessoa.
    // Aluno é uma especialização de Pessoa, mostrando como herança cria hierarquias.
    public class Aluno : Pessoa
    {
        // Construtor padrão: chama o construtor base (Pessoa()) implicitamente.
        // Permite criar Aluno sem parâmetros, definindo atributos depois, como em Program.cs (a2).
        // Isso oferece flexibilidade, associado à herança, pois herda construtores da base.
        public Aluno()
        {
        }

        // Construtor com parâmetro (nome): chama o construtor base com nome usando : base(nome).
        // Isso inicializa Nome via Pessoa, demonstrando herança de construtores.
        // Usado em Program.cs para Aluno a1 = new Aluno("Lucas");, mostrando como subclasses chamam base.
        public Aluno(string nome) : base(nome)
        {
        }

        // Propriedade Nota: específica de Aluno, armazena a nota do aluno.
        // Pública para acesso direto, mas em encapsulamento real poderia ser privada com validações.
        // Adicionada via herança, pois Pessoa não tem Nota; isso especializa Aluno.
        // Usada em Apresentar() para incluir na mensagem, associada ao polimorfismo.
        public double Nota { get; set; }

        // Método Apresentar() sobrescrito: chama base.Apresentar() implicitamente, mas adiciona Nota.
        // Override permite comportamento específico: inclui nota na mensagem.
        // Isso demonstra polimorfismo, onde o mesmo método varia por tipo (Pessoa vs. Aluno).
        // Chamado em Program.cs, mostrando como herança e polimorfismo interagem.
        public override void Apresentar()
        {
            // Escreve mensagem incluindo Nome, Idade (herdados) e Nota (específica).
            // Usa interpolação para inserir valores, associada à abstração de apresentação.
            // Difere de Pessoa.Apresentar(), ilustrando como subclasses estendem comportamento.
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. Minha nota é {Nota}.");
        }
    }
}
