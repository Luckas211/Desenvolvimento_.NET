using System;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar introdução à manipulação de valores em C#.
    /// Mostra como declarar variáveis, atribuir valores e realizar operações básicas.
    /// Exemplo simples: calcular o preço total de produtos em uma loja.
    /// </summary>
    public class IntroducaoManipulandoValores
    {
        /// <summary>
        /// Método que executa o exemplo de manipulação de valores.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 1. Introdução Manipulando Valores ===");

            // Declarando variáveis: int para números inteiros, double para decimais.
            // Em OOP, usamos variáveis dentro de métodos para encapsular lógica.
            int quantidadeProdutos = 5; // Número de produtos comprados
            double precoUnitario = 10.50; // Preço de cada produto

            // Manipulando valores: multiplicação para calcular total
            double total = quantidadeProdutos * precoUnitario;

            // Exibindo resultados no console
            Console.WriteLine($"Quantidade de produtos: {quantidadeProdutos}");
            Console.WriteLine($"Preço unitário: R$ {precoUnitario}");
            Console.WriteLine($"Total a pagar: R$ {total}");

            // Exemplo de alteração de valor: aplicando desconto
            double desconto = 2.00; // Desconto fixo
            total -= desconto; // Subtração para aplicar desconto

            Console.WriteLine($"Após desconto de R$ {desconto}: R$ {total}");
            Console.WriteLine(); // Linha em branco para separar exemplos
        }
    }
}
