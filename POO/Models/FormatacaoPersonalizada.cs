using System;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar formatação personalizada em C#.
    /// Mostra como usar formatos customizados para números e datas.
    /// Exemplo: formatar CPF, telefone e datas de forma específica.
    /// </summary>
    public class FormatacaoPersonalizada
    {
        /// <summary>
        /// Método que executa o exemplo de formatação personalizada.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 9. Formatação Personalizada ===");

            // Números de telefone e CPF
            long telefone = 11987654321;
            long cpf = 12345678901;

            // Formatação personalizada usando ToString com padrões
            string telefoneFormatado = telefone.ToString("(00) 00000-0000");
            string cpfFormatado = cpf.ToString("000.000.000-00");

            Console.WriteLine($"Telefone: {telefoneFormatado}");
            Console.WriteLine($"CPF: {cpfFormatado}");

            // Data personalizada
            DateTime data = DateTime.Now;
            string dataPersonalizada = data.ToString("dd/MM/yyyy HH:mm:ss");

            Console.WriteLine($"Data e hora: {dataPersonalizada}");

            // Número com separador personalizado
            double valor = 1234567.89;
            string valorFormatado = valor.ToString("#,##0.00");

            Console.WriteLine($"Valor: {valorFormatado}");
            Console.WriteLine();
        }
    }
}
