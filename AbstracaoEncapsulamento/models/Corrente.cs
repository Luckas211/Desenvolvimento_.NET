// Importa namespaces padrão do .NET, como System para Console.
// Embora não use Collections, Linq ou Tasks, são incluídos por convenção.
// Isso permite Console.WriteLine em Creditar().
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Define o namespace do projeto, agrupando classes relacionadas.
// Isso mantém organização e evita conflitos de nomes.
namespace AbstracaoEncapsulamento.models
{
    // Classe Corrente: herda de Conta, implementando Creditar() para conta corrente.
    // Como Conta é abstrata, Corrente fornece implementação concreta.
    // Isso demonstra herança e polimorfismo: Corrente é uma Conta, mas com comportamento específico.
    // Usada em Program.cs: Conta c = new Corrente();, mostrando abstração via polimorfismo.
    public class Corrente : Conta
    {
        // Método Creditar sobrescrito: implementa depósito adicionando valor ao Saldo.
        // Override de método abstrato em Conta, obrigatório para subclasses.
        // Acessa Saldo (protected) da base, mostrando como herança permite compartilhamento.
        // Tipo decimal para Valor, associado a precisão monetária.
        // Chamado em Program.cs, demonstrando como subclasses concretizam abstrações.
        public override void Creditar(decimal Valor)
        {
            // Adiciona Valor ao Saldo, encapsulando a lógica de depósito.
            // Saldo é herdado e protegido, acessível aqui para modificação controlada.
            Saldo += Valor;

            // Exibe mensagem de sucesso, associada ao feedback de operações bancárias.
            // Isso abstrai a confirmação, parte do comportamento de conta corrente.
            Console.WriteLine("Depósito realizado com sucesso!");
        }
    }
}
