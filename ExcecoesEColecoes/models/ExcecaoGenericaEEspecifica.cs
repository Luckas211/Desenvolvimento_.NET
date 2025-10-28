using System; // Importa o namespace System para usar classes como Console e Exception

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar exceções genéricas e específicas em C#.
    /// Mostra a diferença entre catch(Exception) e catch específico.
    /// Exemplo: operações que podem lançar diferentes tipos de erro.
    /// </summary>
    public class ExcecaoGenericaEEspecifica // Declara uma classe pública chamada ExcecaoGenericaEEspecifica
    {
        /// <summary>
        /// Método que executa o exemplo de exceções genéricas e específicas.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 5. Exceção Genérica e Específica ==="); // Escreve uma mensagem no console indicando o início do exemplo

            try // Inicia um bloco try para tentar executar código que pode lançar exceções
            {
                // Simula diferentes operações que podem falhar
                string[] array = new string[3]; // Declara um array de strings com 3 posições
                array[5] = "teste"; // Tenta acessar índice 5 (fora do limite), lançando IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex) // Captura especificamente a exceção IndexOutOfRangeException
            {
                // Trata especificamente erro de índice
                Console.WriteLine($"Erro de índice: {ex.Message}"); // Escreve a mensagem de erro no console
            }
            catch (NullReferenceException ex) // Captura especificamente a exceção NullReferenceException
            {
                // Trata especificamente referência nula
                Console.WriteLine($"Referência nula: {ex.Message}"); // Escreve a mensagem de erro no console
            }
            catch (Exception ex) // Captura qualquer outra exceção
            {
                // Trata qualquer outra exceção não especificada
                Console.WriteLine($"Erro geral: {ex.Message}"); // Escreve a mensagem de erro no console
            }

            // Ordem importa: exceções específicas antes da genérica
            // Exception captura tudo, então deve ser a última
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe ExcecaoGenericaEEspecifica
} // Fecha o namespace
