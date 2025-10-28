using System; // Importa o namespace System para usar classes como Console e Exception

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar introdução às exceções em C#.
    /// Mostra o que são exceções e como elas ocorrem em operações inválidas.
    /// Exemplo: tentar dividir por zero.
    /// </summary>
    public class IntroducaoExcecoes // Declara uma classe pública chamada IntroducaoExcecoes
    {
        /// <summary>
        /// Método que executa o exemplo de introdução às exceções.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 1. Introdução às Exceções ==="); // Escreve uma mensagem no console indicando o início do exemplo

            try // Inicia um bloco try para tentar executar código que pode lançar exceções
            {
                // Tentativa de divisão por zero, que lança DivideByZeroException
                int numero = 10; // Declara uma variável inteira numero e atribui o valor 10
                int divisor = 0; // Declara uma variável inteira divisor e atribui o valor 0
                int resultado = numero / divisor; // Tenta dividir numero por divisor, o que lança uma DivideByZeroException
                Console.WriteLine($"Resultado: {resultado}"); // Escreve o resultado no console (essa linha não será executada devido à exceção)
            }
            catch (DivideByZeroException ex) // Captura especificamente a exceção DivideByZeroException e armazena em ex
            {
                // Captura a exceção específica
                Console.WriteLine($"Erro: {ex.Message}"); // Escreve a mensagem de erro da exceção no console
            }

            // Exceções são erros que ocorrem durante a execução do programa
            // Elas interrompem o fluxo normal se não forem tratadas
            Console.WriteLine("Programa continua após tratar a exceção."); // Escreve uma mensagem indicando que o programa continua
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe IntroducaoExcecoes
} // Fecha o namespace
