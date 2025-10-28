using System;
using System.Globalization;
using System.Threading;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar alteração da localização (cultura) do código em C#.
    /// Mostra como mudar a cultura para afetar formatação de datas e moedas.
    /// Exemplo: exibir data e preço em diferentes culturas.
    /// </summary>
    public class AlterandoLocalizacaoDoCodigo
    {
        /// <summary>
        /// Método que executa o exemplo de alteração de localização.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 7. Alterando Localização do Código ===");

            // Data atual
            DateTime hoje = DateTime.Now;
            double preco = 1234.56;

            // Cultura padrão (atual do sistema)
            Console.WriteLine("Cultura padrão:");
            Console.WriteLine($"Data: {hoje.ToString("D")}");
            Console.WriteLine($"Preço: {preco.ToString("C")}");

            // Alterando para cultura dos EUA (en-US)
            CultureInfo culturaUS = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = culturaUS;

            Console.WriteLine("\nAlterado para en-US:");
            Console.WriteLine($"Data: {hoje.ToString("D")}");
            Console.WriteLine($"Preço: {preco.ToString("C")}");

            // Alterando para cultura brasileira (pt-BR)
            CultureInfo culturaBR = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culturaBR;

            Console.WriteLine("\nAlterado para pt-BR:");
            Console.WriteLine($"Data: {hoje.ToString("D")}");
            Console.WriteLine($"Preço: {preco.ToString("C")}");

            // Resetando para cultura padrão
            Thread.CurrentThread.CurrentCulture = CultureInfo.CurrentCulture;
            Console.WriteLine();
        }
    }
}
