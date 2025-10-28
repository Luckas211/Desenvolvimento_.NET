using System;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar ajuste de numeração em C#.
    /// Mostra como formatar números com casas decimais usando ToString.
    /// Exemplo: exibir preços de produtos com 2 casas decimais.
    /// </summary>
    public class AjustandoNumeracao
    {
        /// <summary>
        /// Método que executa o exemplo de ajuste de numeração.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 4. Ajustando Numeração ===");

            // Declarando valores decimais
            double preco1 = 15.5;
            double preco2 = 20.123456;

            // Ajustando para 2 casas decimais usando ToString("F2")
            // "F2" significa Fixed-point com 2 casas decimais
            string precoFormatado1 = preco1.ToString("F2");
            string precoFormatado2 = preco2.ToString("F3"); // 3 Casas decimas = F3

            Console.WriteLine($"Preço 1: R$ {precoFormatado1}");
            Console.WriteLine($"Preço 2: R$ {precoFormatado2}");

            // Exemplo com mais casas: "F3" para 3 casas decimais
            double medida = 123.456789;
            string medidaFormatada = medida.ToString("F3");
            Console.WriteLine($"Medida: {medidaFormatada} cm");

            // Sem formatação: mostra todos os decimais
            Console.WriteLine($"Sem formatação: {preco2}");
            Console.WriteLine();
        }
    }
}
