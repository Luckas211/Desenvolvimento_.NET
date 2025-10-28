using System; // Importa o namespace System para usar classes como Console
using System.Collections.Generic; // Importa o namespace System.Collections.Generic para usar classes como Queue

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar fila na prática em C#.
    /// Mostra operações comuns com Queue<T>.
    /// Exemplo: simular fila de impressão de documentos.
    /// </summary>
    public class FilaNaPratica // Declara uma classe pública chamada FilaNaPratica
    {
        /// <summary>
        /// Método que executa o exemplo de fila na prática.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 9. Fila na Prática ==="); // Escreve uma mensagem no console indicando o início do exemplo

            Queue<string> filaImpressao = new Queue<string>(); // Declara e inicializa uma Queue de strings para documentos

            // Adiciona documentos à fila
            filaImpressao.Enqueue("Documento1.pdf"); // Adiciona "Documento1.pdf" à fila
            filaImpressao.Enqueue("Documento2.docx"); // Adiciona "Documento2.docx" à fila
            filaImpressao.Enqueue("Documento3.txt"); // Adiciona "Documento3.txt" à fila

            Console.WriteLine("Documentos na fila de impressão:"); // Escreve uma mensagem no console
            foreach (string doc in filaImpressao) // Itera sobre cada documento na fila
            {
                Console.WriteLine(doc); // Escreve o documento no console
            }

            // Processa a fila
            while (filaImpressao.Count > 0) // Enquanto houver elementos na fila
            {
                string documento = filaImpressao.Dequeue(); // Remove e obtém o primeiro documento da fila
                Console.WriteLine($"Imprimindo: {documento}"); // Escreve o documento sendo impresso no console
            }

            Console.WriteLine("Fila vazia. Todos os documentos impressos."); // Escreve uma mensagem indicando que a fila está vazia
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe FilaNaPratica
} // Fecha o namespace
