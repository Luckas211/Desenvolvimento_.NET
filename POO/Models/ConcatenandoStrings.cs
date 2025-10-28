using System;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar concatenação de strings em C#.
    /// Mostra como juntar textos usando + e string.Concat.
    /// Exemplo: montar uma mensagem de boas-vindas para um cliente.
    /// </summary>
    public class ConcatenandoStrings
    {
        /// <summary>
        /// Método que executa o exemplo de concatenação de strings.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 2. Concatenando Strings ===");

            // Declarando strings: textos em C# são do tipo string
            string nome = "João";
            string sobrenome = "Silva";
            string saudacao = "Olá, ";

            // Concatenação usando operador +: junta textos
            string mensagem1 = saudacao + nome + " " + sobrenome + "!";

            // Concatenação usando string.Concat: método estático da classe string
            string mensagem2 = string.Concat(saudacao, nome, " ", sobrenome, "!");

            // Exibindo resultados
            Console.WriteLine("Usando +: " + mensagem1);
            Console.WriteLine("Usando string.Concat: " + mensagem2);

            // Exemplo prático: mensagem personalizada
            string produto = "notebook";
            int quantidade = 2;
            string mensagemCompra = "Você comprou " + quantidade + " " + produto + "(s).";
            Console.WriteLine(mensagemCompra);
            Console.WriteLine();
        }
    }
}
