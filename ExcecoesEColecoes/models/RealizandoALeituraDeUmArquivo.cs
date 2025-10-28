using System; // Importa o namespace System para usar classes como Console
using System.IO; // Importa o namespace System.IO para usar classes como File

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar leitura de arquivo em C#.
    /// Mostra como usar File.ReadAllLines para ler conteúdo de um arquivo.
    /// Exemplo: ler um arquivo de texto com informações de produtos.
    /// </summary>
    public class RealizandoALeituraDeUmArquivo // Declara uma classe pública chamada RealizandoALeituraDeUmArquivo
    {
        /// <summary>
        /// Método que executa o exemplo de leitura de arquivo.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 2. Realizando a Leitura de um Arquivo ==="); // Escreve uma mensagem no console indicando o início do exemplo

            string caminhoArquivo = "Arquivos/ArquivoLeitura.txt"; // Declara uma string com o caminho relativo do arquivo

            try // Inicia um bloco try para tentar executar código que pode lançar exceções
            {
                // Lê todas as linhas do arquivo
                string[] linhas = File.ReadAllLines(caminhoArquivo); // Lê todas as linhas do arquivo e armazena em um array de strings

                Console.WriteLine("Conteúdo do arquivo:"); // Escreve uma mensagem no console
                foreach (string linha in linhas) // Itera sobre cada linha do array
                {
                    Console.WriteLine(linha); // Escreve a linha no console
                }
            }
            catch (FileNotFoundException ex) // Captura especificamente a exceção FileNotFoundException
            {
                Console.WriteLine($"Arquivo não encontrado: {ex.Message}"); // Escreve a mensagem de erro no console
            }
            catch (IOException ex) // Captura especificamente a exceção IOException
            {
                Console.WriteLine($"Erro de I/O: {ex.Message}"); // Escreve a mensagem de erro no console
            }

            // Leitura de arquivo é útil para carregar dados persistidos
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe RealizandoALeituraDeUmArquivo
} // Fecha o namespace
