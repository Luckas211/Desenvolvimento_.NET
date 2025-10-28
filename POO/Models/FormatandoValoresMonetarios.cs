using System;
using System.Globalization;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar formatação de valores monetários em C#.
    /// Mostra como formatar preços usando "C" para moeda.
    /// Exemplo: exibir preços de itens em uma loja.
    /// </summary>
    public class FormatandoValoresMonetarios
    {
        /// <summary>
        /// Método que executa o exemplo de formatação monetária.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 6. Formatando Valores Monetários ===");

            // Declarando preços
            double precoLivro = 29.90;
            double precoComputador = 2500.00;
            double precoCafe = 4.50;

            // Formatando como moeda usando "C" (Currency)
            // Usa a cultura padrão do sistema (geralmente pt-BR no Brasil)
            string precoLivroFormatado = precoLivro.ToString("C");
            string precoComputadorFormatado = precoComputador.ToString("C");
            string precoCafeFormatado = precoCafe.ToString("C");

            Console.WriteLine($"Livro: {precoLivroFormatado}");
            Console.WriteLine($"Computador: {precoComputadorFormatado}");
            Console.WriteLine($"Café: {precoCafeFormatado}");

            // Exemplo com cultura específica: en-US (dólar)
            CultureInfo culturaUS = new CultureInfo("en-US");
            string precoUSD = precoComputador.ToString("C", culturaUS);
            Console.WriteLine($"Computador em USD: {precoUSD}");
            Console.WriteLine();
        }
    }
}
