using System;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar uso de DateTime com TryParse em C#.
    /// Mostra como tentar converter string para DateTime sem lançar exceções.
    /// Exemplo: validar datas inseridas pelo usuário.
    /// </summary>
    public class DateTimeComTryParse
    {
        /// <summary>
        /// Método que executa o exemplo de DateTime com TryParse.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 12. DateTime com TryParse ===");

            // Strings representando datas
            string dataValida = "15/05/2023";
            string dataInvalida = "data inválida";
            string dataValidaUS = "05/15/2023";

            // Tentando converter usando TryParse
            // Retorna true se conseguiu, false se não
            if (DateTime.TryParse(dataValida, out DateTime resultado1))
            {
                Console.WriteLine($"Data válida: {resultado1.ToString("D")}");
            }
            else
            {
                Console.WriteLine("Falha ao converter data válida.");
            }

            if (DateTime.TryParse(dataInvalida, out DateTime resultado2))
            {
                Console.WriteLine($"Data inválida convertida: {resultado2}");
            }
            else
            {
                Console.WriteLine("Data inválida não pôde ser convertida.");
            }

            // Com cultura específica
            var culturaBR = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
            if (DateTime.TryParse(dataValidaUS, culturaBR, System.Globalization.DateTimeStyles.None, out DateTime resultado3))
            {
                Console.WriteLine($"Data US com cultura BR: {resultado3.ToString("D")}");
            }
            else
            {
                Console.WriteLine("Falha ao converter data US.");
            }

            Console.WriteLine();
        }
    }
}
