using System; // Importa o namespace System para usar classes como Console e Exception

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar como disparar uma exceção em C#.
    /// Mostra o uso de throw para lançar exceções personalizadas.
    /// Exemplo: validar idade e lançar exceção se inválida.
    /// </summary>
    public class DisparandoUmaExcecao // Declara uma classe pública chamada DisparandoUmaExcecao
    {
        /// <summary>
        /// Método que executa o exemplo de disparar uma exceção.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 3. Disparando uma Exceção ==="); // Escreve uma mensagem no console indicando o início do exemplo

            try // Inicia um bloco try para tentar executar código que pode lançar exceções
            {
                // Simula entrada de usuário
                int idade = -5; // Declara uma variável inteira idade e atribui o valor -5 (idade inválida)

                if (idade < 0) // Verifica se a idade é menor que 0
                {
                    // Lança uma exceção personalizada
                    throw new ArgumentException("A idade não pode ser negativa."); // Lança uma ArgumentException com mensagem personalizada
                }

                Console.WriteLine($"Idade válida: {idade}"); // Escreve a idade no console se for válida
            }
            catch (ArgumentException ex) // Captura especificamente a exceção ArgumentException
            {
                Console.WriteLine($"Erro: {ex.Message}"); // Escreve a mensagem de erro no console
            }

            // throw é usado para sinalizar condições de erro
            // Pode lançar exceções built-in ou customizadas
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe DisparandoUmaExcecao
} // Fecha o namespace
