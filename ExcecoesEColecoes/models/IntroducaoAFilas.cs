using System; // Importa o namespace System para usar classes como Console
using System.Collections.Generic; // Importa o namespace System.Collections.Generic para usar classes como Queue

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar introdução às filas (Queue) em C#.
    /// Mostra o conceito FIFO (First In, First Out).
    /// Exemplo: fila de atendimento em um banco.
    /// </summary>
    public class IntroducaoAFilas // Declara uma classe pública chamada IntroducaoAFilas
    {
        /// <summary>
        /// Método que executa o exemplo de introdução às filas.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 8. Introdução às Filas ==="); // Escreve uma mensagem no console indicando o início do exemplo

            // Cria uma fila de strings
            Queue<string> fila = new Queue<string>(); // Declara e inicializa uma Queue de strings

            // Adiciona elementos (Enqueue)
            fila.Enqueue("Cliente 1"); // Adiciona "Cliente 1" ao final da fila
            fila.Enqueue("Cliente 2"); // Adiciona "Cliente 2" ao final da fila
            fila.Enqueue("Cliente 3"); // Adiciona "Cliente 3" ao final da fila

            Console.WriteLine("Fila de atendimento:"); // Escreve uma mensagem no console
            foreach (string cliente in fila) // Itera sobre cada elemento da fila
            {
                Console.WriteLine(cliente); // Escreve o cliente no console
            }

            // Remove o primeiro (Dequeue)
            string proximo = fila.Dequeue(); // Remove e retorna o primeiro elemento da fila
            Console.WriteLine($"Atendendo: {proximo}"); // Escreve o cliente sendo atendido no console

            // Peek mostra o próximo sem remover
            string proximoPeek = fila.Peek(); // Retorna o primeiro elemento sem removê-lo
            Console.WriteLine($"Próximo na fila: {proximoPeek}"); // Escreve o próximo cliente no console

            // Filas são úteis para processamento sequencial
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe IntroducaoAFilas
} // Fecha o namespace
