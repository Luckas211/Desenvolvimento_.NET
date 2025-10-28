using System;
using System.Globalization;
using System.Threading;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar alteração da localização da cultura em C#.
    /// Mostra como definir cultura específica para formatação.
    /// Exemplo: formatar números e datas em português e inglês.
    /// </summary>
    public class AlterandoLocalizacaoDaCultura
    {
        /// <summary>
        /// Método que executa o exemplo de alteração da cultura.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 8. Alterando Localização da Cultura ===");

            // Valores para formatar
            DateTime data = new DateTime(2023, 12, 25);
            double numero = 12345.67;

            // Usando cultura brasileira
            CultureInfo culturaBR = new CultureInfo("pt-BR");
            string dataBR = data.ToString("D", culturaBR);
            string numeroBR = numero.ToString("N", culturaBR);

            Console.WriteLine("Cultura pt-BR:");
            Console.WriteLine($"Data: {dataBR}");
            Console.WriteLine($"Número: {numeroBR}");

            // Usando cultura americana
            CultureInfo culturaUS = new CultureInfo("en-US");
            string dataUS = data.ToString("D", culturaUS);
            string numeroUS = numero.ToString("N", culturaUS);

            Console.WriteLine("\nCultura en-US:");
            Console.WriteLine($"Data: {dataUS}");
            Console.WriteLine($"Número: {numeroUS}");

            // Definindo cultura para o thread atual
            Thread.CurrentThread.CurrentCulture = culturaBR;
            Console.WriteLine("\nDefinindo cultura pt-BR para o thread:");
            Console.WriteLine($"Data atual: {DateTime.Now.ToString("D")}");
            Console.WriteLine($"Número: {numero.ToString("N")}");
            Console.WriteLine();
        }
    }
}
