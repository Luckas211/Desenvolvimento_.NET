using System; // Importa o namespace System para usar classes como Console e Exception

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar tratamento de exceções em C#.
    /// Mostra como usar try-catch para capturar e tratar erros.
    /// Exemplo: tentar converter string para número.
    /// </summary>
    public class TratandoUmaExcecao // Declara uma classe pública chamada TratandoUmaExcecao
    {
        /// <summary>
        /// Método que executa o exemplo de tratamento de exceção.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 4. Tratando uma Exceção ==="); // Escreve uma mensagem no console indicando o início do exemplo

            try // Inicia um bloco try para tentar executar código que pode lançar exceções
            {
                // Tentativa de conversão que pode falhar
                string entrada = "abc"; // Declara uma string entrada e atribui "abc" (entrada inválida)
                int numero = int.Parse(entrada); // Tenta converter a string para int, o que lança FormatException
                Console.WriteLine($"Número: {numero}"); // Escreve o número no console se a conversão for bem-sucedida
            }
            catch (FormatException ex) // Captura especificamente a exceção FormatException
            {
                // Trata especificamente erro de formato
                Console.WriteLine($"Erro de formato: {ex.Message}"); // Escreve a mensagem de erro no console
                Console.WriteLine("Tente inserir um número válido."); // Escreve uma mensagem de orientação
            }
            catch (Exception ex) // Captura qualquer outra exceção
            {
                // Trata qualquer outra exceção
                Console.WriteLine($"Erro geral: {ex.Message}"); // Escreve a mensagem de erro no console
            }

            // Após o tratamento, o programa continua
            Console.WriteLine("Programa continua executando."); // Escreve uma mensagem indicando que o programa continua
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe TratandoUmaExcecao
} // Fecha o namespace
