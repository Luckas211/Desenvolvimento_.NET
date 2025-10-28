using System;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar representação de porcentagem em C#.
    /// Mostra como formatar valores como porcentagens usando "P".
    /// Exemplo: calcular e exibir descontos e taxas.
    /// </summary>
    public class RepresentandoPorcentagem
    {
        /// <summary>
        /// Método que executa o exemplo de representação de porcentagem.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 10. Representando Porcentagem ===");

            // Valores decimais representando frações (0.1 = 10%)
            double desconto = 0.15; // 15%
            double taxaJuros = 0.05; // 5%
            double aumento = 0.20; // 20%

            // Formatando como porcentagem usando "P"
            string descontoFormatado = desconto.ToString("P");
            string taxaFormatada = taxaJuros.ToString("P");
            string aumentoFormatado = aumento.ToString("P");

            Console.WriteLine($"Desconto: {descontoFormatado}");
            Console.WriteLine($"Taxa de juros: {taxaFormatada}");
            Console.WriteLine($"Aumento: {aumentoFormatado}");

            // Exemplo prático: preço com desconto
            double precoOriginal = 100.00;
            double precoComDesconto = precoOriginal * (1 - desconto);
            Console.WriteLine($"Preço original: R$ {precoOriginal:F2}");
            Console.WriteLine($"Preço com {descontoFormatado} de desconto: R$ {precoComDesconto:F2}");
            Console.WriteLine();
        }
    }
}
