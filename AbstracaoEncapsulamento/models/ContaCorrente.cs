// Importa namespaces padrão do .NET, como System para Console.
// Embora não use Collections, Linq ou Tasks aqui, são comuns em projetos C#.
// Isso permite Console.WriteLine em Sacar() e ExibirSaldo().
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Define o namespace do projeto, agrupando classes relacionadas.
// Isso organiza o código e evita conflitos de nomes.
namespace AbstracaoEncapsulamento.models
{
    // Classe ContaCorrente: representa uma conta corrente concreta, com encapsulamento forte.
    // Diferente de Conta (abstrata), esta é instanciável e foca em operações como saque.
    // Encapsulamento: Saldo é privado, acessível apenas via métodos públicos.
    // Não herda de Conta; é uma implementação separada para demonstrar encapsulamento puro.
    // Usada em Program.cs para mostrar controle de acesso a dados sensíveis.
    public class ContaCorrente
    {
        // Propriedade NumeroConta: pública, armazena o número da conta.
        // Permite identificação da conta, associada a operações bancárias.
        // Pública para acesso direto, mas em sistemas reais poderia ser readonly.
        public int NumeroConta { get; set; }

        // Campo Saldo: privado, encapsula o saldo para proteger de acesso externo.
        // Encapsulamento chave: só modificável via Sacar() e inicialização.
        // Tipo decimal para precisão, associado a valores monetários.
        // Não acessível fora da classe, prevenindo alterações não autorizadas.
        private decimal Saldo;

        // Método Sacar: permite saque com validação de saldo.
        // Encapsula lógica de saque: verifica se há fundos, atualiza Saldo se possível.
        // Retorna mensagens apropriadas, mostrando controle de operações.
        // Chamado em Program.cs, demonstrando encapsulamento em ação.
        public void Sacar(decimal valor)
        {
            // Verifica se Saldo é suficiente para o valor solicitado.
            // Encapsulamento: acesso interno ao Saldo para validação.
            if (Saldo >= valor)
            {
                // Exibe sucesso e subtrai valor do Saldo.
                // Isso mantém integridade: saque só ocorre se válido.
                Console.WriteLine("Saque realizado com sucesso!");
                Saldo -= valor;
            }
            else
            {
                // Exibe erro se saldo insuficiente.
                // Encapsulamento previne saques inválidos, protegendo dados.
                Console.WriteLine("Saldo insuficiente para o saque.");
            }
        }

        // Método ExibirSaldo: mostra saldo da conta no console.
        // Encapsula exibição: acessa Saldo privado e NumeroConta público.
        // Não permite modificação, apenas visualização controlada.
        // Chamado em Program.cs antes e após saque, mostrando estado encapsulado.
        public void ExibirSaldo()
        {
            // Escreve saldo formatado, incluindo NumeroConta.
            // Usa placeholders {0} e {1} para valores dinâmicos.
            // Isso abstrai a exibição, associada ao comportamento de conta.
            Console.WriteLine("Saldo da conta {0}: R${1}", NumeroConta, Saldo);
        }

        // Construtor ContaCorrente: inicializa NumeroConta e Saldo com parâmetros.
        // Permite criação com valores iniciais, encapsulando configuração.
        // Saldo é definido aqui, único ponto de inicialização externa.
        // Usado em Program.cs: new ContaCorrente(123, 1000);.
        public ContaCorrente(int NumeroConta, decimal SaldoInicial)
        {
            // Atribui NumeroConta ao parâmetro.
            // Encapsula definição do número.
            this.NumeroConta = NumeroConta;

            // Atribui SaldoInicial ao campo Saldo privado.
            // Encapsula inicialização do saldo, protegendo de acesso posterior.
            this.Saldo = SaldoInicial;
        }
    }
}
