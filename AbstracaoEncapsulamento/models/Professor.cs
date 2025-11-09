// Importa o namespace System, necessário para usar Console no método Apresentar().
// Isso permite exibir mensagens no console, associado ao comportamento de apresentação.
using System;

// Define o namespace do projeto, agrupando classes relacionadas.
// Isso organiza o código e evita conflitos de nomes.
namespace AbstracaoEncapsulamento.models
{
    // Classe Professor: herda de Pessoa, adicionando propriedade Salario e sobrescrevendo Apresentar().
    // Herança permite reutilizar Nome e Idade de Pessoa, especializando para professor.
    // Isso demonstra polimorfismo: Apresentar() inclui salário, diferindo de Pessoa e Aluno.
    // Professor é outra especialização de Pessoa, mostrando hierarquia via herança.
    public class Professor : Pessoa
    {
        // Construtor com parâmetro (nome): chama base(nome) para inicializar Nome via Pessoa.
        // Não há construtor padrão aqui, forçando inicialização com nome, ao contrário de Aluno.
        // Isso demonstra variação em herança: subclasses podem escolher construtores.
        // Usado em Program.cs para Professor prof1 = new Professor("Carlos");.
        public Professor(string nome) : base(nome)
        {
        }

        // Propriedade Salario: específica de Professor, armazena o salário.
        // Tipo decimal para valores monetários precisos, associado a finanças.
        // Pública para acesso direto, mas encapsulamento poderia adicionar validações (ex.: salário > 0).
        // Adicionada via herança, pois Pessoa não tem Salario; especializa Professor.
        // Usada em Apresentar() para incluir na mensagem, mostrando polimorfismo.
        public decimal Salario { get; set; }

        // Método Apresentar() sobrescrito: inclui Nome, Idade (herdados) e Salario (específico).
        // Override permite comportamento único: menciona salário em reais.
        // Isso demonstra polimorfismo, onde o método varia por subclasse (Pessoa vs. Professor).
        // Chamado em Program.cs, ilustrando como herança permite especializações.
        public override void Apresentar()
        {
            // Escreve mensagem com Nome, Idade e Salario, formatada em reais.
            // Usa interpolação para valores dinâmicos, associada à abstração de apresentação.
            // Difere de Pessoa e Aluno, mostrando como subclasses personalizam comportamento herdado.
            Console.WriteLine($"Olá, meu nome é {Nome} e sou professor, tenho {Idade} anos e ganho R${Salario}.");
        }
    }
}
