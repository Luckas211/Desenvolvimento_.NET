using System; // Importa o namespace System para usar classes como Console
using System.IO; // Importa o namespace System.IO para usar classes como StreamReader

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar o bloco finally em C#.
    /// Mostra que finally executa sempre, independente de exceção.
    /// Exemplo: liberar recursos após operação com arquivo.
    /// </summary>
    public class EntendendoOBlocoFinally // Declara uma classe pública chamada EntendendoOBlocoFinally
    {
        /// <summary>
        /// Método que executa o exemplo do bloco finally.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 6. Entendendo o Bloco Finally ==="); // Escreve uma mensagem no console indicando o início do exemplo

            StreamReader reader = null; // Declara uma variável StreamReader inicializada como null
            try // Inicia um bloco try para tentar executar código que pode lançar exceções
            {
                // Abre um arquivo para leitura
                reader = new StreamReader("Arquivos/ArquivoLeitura.txt"); // Cria um StreamReader para ler o arquivo
                string conteudo = reader.ReadToEnd(); // Lê todo o conteúdo do arquivo
                Console.WriteLine("Conteúdo lido:"); // Escreve uma mensagem no console
                Console.WriteLine(conteudo); // Escreve o conteúdo lido no console
            }
            catch (FileNotFoundException ex) // Captura especificamente a exceção FileNotFoundException
            {
                Console.WriteLine($"Arquivo não encontrado: {ex.Message}"); // Escreve a mensagem de erro no console
            }
            finally // Bloco que sempre executa, independente de exceção
            {
                // Sempre executa, mesmo se houve exceção
                if (reader != null) // Verifica se reader não é null
                {
                    reader.Close(); // Fecha o StreamReader
                    Console.WriteLine("Arquivo fechado no finally."); // Escreve uma mensagem no console
                }
                else // Se reader é null
                {
                    Console.WriteLine("Finally executado, mas reader era null."); // Escreve uma mensagem no console
                }
            }

            // finally é ideal para liberar recursos (arquivos, conexões, etc.)
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe EntendendoOBlocoFinally
} // Fecha o namespace
