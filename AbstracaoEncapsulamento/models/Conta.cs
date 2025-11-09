// Importa namespaces padrão do .NET, como System para Console.
// Embora não use Collections, Linq ou Tasks aqui, são comuns em projetos C#.
// Isso permite usar Console.WriteLine em ExibirSaldo().
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Define o namespace do projeto, agrupando classes relacionadas.
// Isso organiza o código e evita conflitos.
namespace AbstracaoEncapsulamento.models
{
    // Classe Conta: abstrata, define estrutura base para contas bancárias.
    // Abstração significa focar no essencial (saldo, creditar), sem implementação específica.
    // Não pode ser instanciada diretamente; subclasses como Corrente devem implementar métodos abstratos.
    // Isso força consistência: todas as contas têm Saldo e Creditar(), mas comportamentos variam.
    // Usada em Program.cs via polimorfismo: Conta c = new Corrente();.
    public abstract class Conta
    {
        // Campo Saldo: protegido (protected), acessível em subclasses, mas não fora.
        // Encapsula o saldo, protegendo de acesso direto externo, parte do encapsulamento.
        // Subclasses como Corrente modificam Saldo via Creditar(), mantendo controle.
        // Tipo decimal para precisão monetária, associado a finanças.
        protected decimal Saldo;

        // Método Creditar abstrato: deve ser implementado por subclasses.
        // Abstrato significa sem corpo; subclasses definem como creditar (ex.: adicionar ao saldo).
        // Isso promove abstração: Conta define "o que" (creditar), subclasses "como".
        // Chamado em Program.cs via polimorfismo, usando implementação de Corrente.
        public abstract void Creditar(decimal Valor);

        // Método ExibirSaldo: concreto, exibe saldo no console.
        // Não abstrato, pois todas as contas exibem saldo da mesma forma.
        // Usa Saldo protegido, mostrando como subclasses acessam campos base.
        // Chamado em Program.cs após operações, demonstrando estado encapsulado.
        public void ExibirSaldo()
        {
            // Escreve saldo formatado em reais, usando placeholder {0}.
            // Isso abstrai a exibição, associada ao comportamento comum de contas.
            Console.WriteLine("Saldo da conta: R${0}", Saldo);
        }
    }
}
