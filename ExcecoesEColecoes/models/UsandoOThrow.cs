using System; // Importa o namespace System para usar classes como Console e Exception

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar o uso de throw em C#.
    /// Mostra como relançar exceções ou lançar novas.
    /// Exemplo: validar entrada e relançar com mensagem personalizada.
    /// </summary>
    public class UsandoOThrow // Declara uma classe pública chamada UsandoOThrow
    {
        /// <summary>
        /// Método que executa o exemplo de uso de throw.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 7. Usando o Throw ==="); // Escreve uma mensagem no console indicando o início do exemplo

            try // Inicia um bloco try para tentar executar código que pode lançar exceções
            {
                // Chama um método que pode lançar exceção
                ValidarIdade(-10); // Chama o método ValidarIdade com valor negativo
            }
            catch (ArgumentException ex) // Captura especificamente a exceção ArgumentException
            {
                Console.WriteLine($"Exceção capturada: {ex.Message}"); // Escreve a mensagem da exceção no console
                // Pode relançar a mesma exceção
                // throw; // Relança a exceção original
                // Ou lançar uma nova
                throw new InvalidOperationException("Operação inválida devido a idade negativa.", ex); // Lança uma nova InvalidOperationException com a original como inner exception
            }
            catch (InvalidOperationException ex) // Captura especificamente a exceção InvalidOperationException
            {
                Console.WriteLine($"Nova exceção: {ex.Message}"); // Escreve a mensagem da nova exceção no console
            }

            // throw pode ser usado para relançar ou criar novas exceções
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar

        private void ValidarIdade(int idade) // Declara um método privado sem retorno chamado ValidarIdade que recebe um int
        {
            if (idade < 0) // Verifica se idade é menor que 0
            {
                throw new ArgumentException("Idade não pode ser negativa."); // Lança uma ArgumentException se condição for verdadeira
            }
        } // Fecha o método ValidarIdade
    } // Fecha a classe UsandoOThrow
} // Fecha o namespace
