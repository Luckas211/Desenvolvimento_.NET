using System;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar formatação de data e hora em C#.
    /// Mostra como formatar DateTime usando padrões como "d", "D", "t", "T".
    /// Exemplo: exibir datas de eventos e horários.
    /// </summary>
    public class FormatandoDataEHora
    {
        /// <summary>
        /// Método que executa o exemplo de formatação de data e hora.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 11. Formatando Data e Hora ===");

            // Data atual
            DateTime agora = DateTime.Now;

            // Formatos curtos
            string dataCurta = agora.ToString("d"); // dd/MM/yyyy
            string horaCurta = agora.ToString("t"); // HH:mm

            Console.WriteLine($"Data curta: {dataCurta}");
            Console.WriteLine($"Hora curta: {horaCurta}");

            // Formatos longos
            string dataLonga = agora.ToString("D"); // dia da semana, dia mês ano
            string horaLonga = agora.ToString("T"); // HH:mm:ss

            Console.WriteLine($"Data longa: {dataLonga}");
            Console.WriteLine($"Hora longa: {horaLonga}");

            // Formato personalizado
            string formatoPersonalizado = agora.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"Formato personalizado: {formatoPersonalizado}");

            // Exemplo com data específica
            DateTime aniversario = new DateTime(1990, 5, 15);
            Console.WriteLine($"Aniversário: {aniversario.ToString("D")}");
            Console.WriteLine();
        }
    }
}
