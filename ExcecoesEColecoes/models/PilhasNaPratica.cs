using System; // Importa o namespace System para usar classes como Console
using System.Collections.Generic; // Importa o namespace System.Collections.Generic para usar classes como Stack

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar pilhas na prática em C#.
    /// Mostra operações comuns com Stack<T>.
    /// Exemplo: simular histórico de navegação web.
    /// </summary>
    public class PilhasNaPratica // Declara uma classe pública chamada PilhasNaPratica
    {
        /// <summary>
        /// Método que executa o exemplo de pilhas na prática.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 11. Pilhas na Prática ==="); // Escreve uma mensagem no console indicando o início do exemplo

            Stack<string> historico = new Stack<string>(); // Declara e inicializa uma Stack de strings para histórico

            // Simula navegação
            historico.Push("Página Inicial"); // Adiciona "Página Inicial" ao topo da pilha
            historico.Push("Página Sobre"); // Adiciona "Página Sobre" ao topo da pilha
            historico.Push("Página Contato"); // Adiciona "Página Contato" ao topo da pilha

            Console.WriteLine("Histórico de navegação:"); // Escreve uma mensagem no console
            foreach (string pagina in historico) // Itera sobre cada página no histórico
            {
                Console.WriteLine(pagina); // Escreve a página no console
            }

            // Voltar página (pop)
            string atual = historico.Pop(); // Remove e retorna a página do topo da pilha
            Console.WriteLine($"Voltando de: {atual}"); // Escreve a página de onde está voltando no console

            // Página atual
            string paginaAtual = historico.Peek(); // Retorna a página do topo sem removê-la
            Console.WriteLine($"Página atual: {paginaAtual}"); // Escreve a página atual no console

            // Adiciona nova página
            historico.Push("Página Serviços"); // Adiciona "Página Serviços" ao topo da pilha
            Console.WriteLine("Nova página adicionada ao histórico."); // Escreve uma mensagem no console
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe PilhasNaPratica
} // Fecha o namespace
