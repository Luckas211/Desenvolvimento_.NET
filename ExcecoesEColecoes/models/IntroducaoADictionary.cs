using System; // Importa o namespace System para usar classes como Console
using System.Collections.Generic; // Importa o namespace System.Collections.Generic para usar classes como Dictionary

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para demonstrar introdução ao Dictionary em C#.
    /// Mostra como usar pares chave-valor.
    /// Exemplo: dicionário de contatos com nome e telefone.
    /// </summary>
    public class IntroducaoADictionary // Declara uma classe pública chamada IntroducaoADictionary
    {
        /// <summary>
        /// Método que executa o exemplo de introdução ao Dictionary.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 12. Introdução ao Dictionary ==="); // Escreve uma mensagem no console indicando o início do exemplo

            // Cria um dicionário string -> string
            Dictionary<string, string> contatos = new Dictionary<string, string>(); // Declara e inicializa um Dictionary com chave string e valor string

            // Adiciona pares chave-valor
            contatos.Add("João", "1234-5678"); // Adiciona par chave-valor usando Add
            contatos.Add("Maria", "9876-5432"); // Adiciona par chave-valor usando Add
            contatos["Pedro"] = "5555-1234"; // Adiciona par chave-valor usando indexador

            Console.WriteLine("Contatos:"); // Escreve uma mensagem no console
            contatos.Remove("Maria"); // Remove o par chave-valor associado à chave "Maria")
            foreach (var contato in contatos) // Itera sobre cada par chave-valor no dicionário
            {
                Console.WriteLine($"{contato.Key}: {contato.Value}"); // Escreve chave e valor no console
            }

            // Acessa valor pela chave
            string telefoneJoao = contatos["João"]; // Acessa o valor associado à chave "João"
            Console.WriteLine($"Telefone do João: {telefoneJoao}"); // Escreve o telefone no console

            // Verifica se chave existe
            if (contatos.ContainsKey("Ana")) // Verifica se a chave "Ana" existe no dicionário
            {
                Console.WriteLine("Ana está nos contatos."); // Escreve mensagem se chave existir
            }
            else
            {
                Console.WriteLine("Ana não está nos contatos."); // Escreve mensagem se chave não existir
            }

            // Dictionaries são ideais para buscas rápidas por chave
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe IntroducaoADictionary
} // Fecha o namespace
