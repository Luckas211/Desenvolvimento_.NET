using System; // Importa o namespace System para usar classes como Console
using System.Collections.Generic; // Importa o namespace System.Collections.Generic para usar classes como Dictionary

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar remoção e alteração de elementos em Dictionary.
    /// Mostra operações de modificar valores e remover chaves.
    /// Exemplo: gerenciar um inventário de produtos.
    /// </summary>
    public class RemovendoEAlterandoElementos // Declara uma classe pública chamada RemovendoEAlterandoElementos
    {
        /// <summary>
        /// Método que executa o exemplo de remoção e alteração.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 13. Removendo e Alterando Elementos ==="); // Escreve uma mensagem no console indicando o início do exemplo

            Dictionary<string, int> inventario = new Dictionary<string, int>(); // Declara e inicializa um Dictionary com chave string e valor int

            // Adiciona produtos
            inventario["Maçã"] = 10; // Adiciona par chave-valor usando indexador
            inventario["Banana"] = 5; // Adiciona par chave-valor usando indexador
            inventario["Laranja"] = 8; // Adiciona par chave-valor usando indexador

            Console.WriteLine("Inventário inicial:"); // Escreve uma mensagem no console
            foreach (var item in inventario) // Itera sobre cada par chave-valor no dicionário
            {
                Console.WriteLine($"{item.Key}: {item.Value}"); // Escreve chave e valor no console
            }

            // Altera quantidade
            inventario["Maçã"] = 15; // Altera o valor associado à chave "Maçã"
            Console.WriteLine("Maçã alterada para 15."); // Escreve mensagem de alteração

            // Remove item
            inventario.Remove("Banana"); // Remove o par chave-valor associado à chave "Banana"
            Console.WriteLine("Banana removida."); // Escreve mensagem de remoção

            Console.WriteLine("Inventário atualizado:"); // Escreve uma mensagem no console
            foreach (var item in inventario) // Itera sobre cada par chave-valor no dicionário atualizado
            {
                Console.WriteLine($"{item.Key}: {item.Value}"); // Escreve chave e valor no console
            }

            // Tenta remover item inexistente
            bool removido = inventario.Remove("Pera"); // Tenta remover chave inexistente, retorna false
            Console.WriteLine($"Tentou remover Pera: {removido}"); // Escreve o resultado da tentativa de remoção

            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe RemovendoEAlterandoElementos
} // Fecha o namespace
