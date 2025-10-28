using System;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar validação do retorno do TryParse em C#.
    /// Mostra como verificar se a conversão foi bem-sucedida e usar o valor.
    /// Exemplo: processar entradas de usuário para datas e números.
    /// </summary>
    public class ValidandoRetornoDoTryParse
    {
        /// <summary>
        /// Método que executa o exemplo de validação do TryParse.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 13. Validando o Retorno do TryParse ===");

            // Simulando entradas do usuário
            string entradaData = "25/12/2023";
            string entradaNumero = "123.45";
            string entradaInvalida = "abc";

            // Validando DateTime
            if (DateTime.TryParse(entradaData, out DateTime dataConvertida))
            {
                Console.WriteLine($"Data válida: {dataConvertida.ToString("D")}");
                // Usar a data convertida, ex: calcular dias até hoje
                TimeSpan diferenca = DateTime.Now - dataConvertida;
                Console.WriteLine($"Dias desde a data: {diferenca.Days}");
            }
            else
            {
                Console.WriteLine("Data inválida. Tente novamente.");
            }

            // Validando double
            if (double.TryParse(entradaNumero, out double numeroConvertido))
            {
                Console.WriteLine($"Número válido: {numeroConvertido:F2}");
                // Usar o número, ex: calcular imposto
                double imposto = numeroConvertido * 0.1;
                Console.WriteLine($"Imposto (10%): R$ {imposto:F2}");
            }
            else
            {
                Console.WriteLine("Número inválido. Digite um valor numérico.");
            }

            // Entrada inválida
            if (int.TryParse(entradaInvalida, out int numeroInvalido))
            {
                Console.WriteLine($"Número: {numeroInvalido}");
            }
            else
            {
                Console.WriteLine("Entrada inválida para número inteiro.");
            }

            Console.WriteLine();
        }
    }
}
