using System; // Importa o namespace System para usar classes como Console
using System.Collections.Generic; // Importa o namespace System.Collections.Generic para usar classes como Stack

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar introdução às pilhas (Stack) em C#.
    /// Mostra o conceito LIFO (Last In, First Out).
    /// Exemplo: pilha de livros em uma mesa.
    /// </summary>
    public class IntroducaoAPilhas // Declara uma classe pública chamada IntroducaoAPilhas
    {
        /// <summary>
        /// Método que executa o exemplo de introdução às pilhas.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 10. Introdução às Pilhas ==="); // Escreve uma mensagem no console indicando o início do exemplo

            // Cria uma pilha de strings
            Stack<string> pilha = new Stack<string>(); // Declara e inicializa uma Stack de strings

            // Adiciona elementos (Push)
            pilha.Push("Livro 1"); // Adiciona "Livro 1" ao topo da pilha
            pilha.Push("Livro 2"); // Adiciona "Livro 2" ao topo da pilha
            pilha.Push("Livro 3"); // Adiciona "Livro 3" ao topo da pilha

            Console.WriteLine("Pilha de livros:"); // Escreve uma mensagem no console
            foreach (string livro in pilha) // Itera sobre cada livro na pilha
            {
                Console.WriteLine(livro); // Escreve o livro no console
            }

            // Remove o topo (Pop)
            string topo = pilha.Pop(); // Remove e retorna o elemento do topo da pilha
            Console.WriteLine($"Removendo do topo: {topo}"); // Escreve o livro removido no console

            // Peek mostra o topo sem remover
            string topoPeek = pilha.Peek(); // Retorna o elemento do topo sem removê-lo
            Console.WriteLine($"Topo atual: {topoPeek}"); // Escreve o topo atual no console

            // Pilhas são úteis para operações de desfazer/refazer
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe IntroducaoAPilhas
} // Fecha o namespace
