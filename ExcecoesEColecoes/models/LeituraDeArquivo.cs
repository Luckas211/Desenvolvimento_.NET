using System; // Importa o namespace System para usar classes como Console
using System.Collections.Generic; // Importa o namespace System.Collections.Generic (não usado neste código, mas incluído)
using System.Linq; // Importa o namespace System.Linq (não usado neste código, mas incluído)
using System.Threading.Tasks; // Importa o namespace System.Threading.Tasks (não usado neste código, mas incluído)
using System.IO; // Importa o namespace System.IO para usar classes como File

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    public class LeituraDeArquivo // Declara uma classe pública chamada LeituraDeArquivo
    {
        public void FazerLeitura() // Declara um método público sem retorno chamado FazerLeitura
        {
            try // Inicia um bloco try para tentar executar código que pode lançar exceções
            {
                string[] linhas = File.ReadAllLines("C:/Users/Administrator/Documents/Manual de Estudo .NET/ExcecoesEColecoes/Arquivos/ArquivoLeitura.txt"); // Lê todas as linhas do arquivo especificado e armazena em um array de strings

                foreach (string linha in linhas) // Itera sobre cada linha do array
                {
                    Console.WriteLine(linha); // Escreve a linha no console
                }
            }
            catch (Exception MensagemDeErro) // Captura qualquer exceção e a armazena na variável MensagemDeErro
            {
                Console.WriteLine("Ocorreu um erro ao ler o arquivo" + MensagemDeErro.Message); // Escreve uma mensagem de erro no console concatenando com a mensagem da exceção
            }
            finally // Bloco que sempre executa, independente de exceção
            {
                Console.WriteLine("Fim do programa. Essa mensagem vai executar ao final do programa funcionando ou não."); // Escreve uma mensagem no console indicando o fim do programa
            }
        } // Fecha o método FazerLeitura

        public void Fifo() //Fifo significa First in First out primeiro a entrar primeiro a sair
        {
            Console.WriteLine("Esse é o nosso Queue = FIFO (First In, First Out)");

            Queue<int> fila = new Queue<int>();
            fila.Enqueue(2);
            fila.Enqueue(4);
            fila.Enqueue(6);
            fila.Enqueue(8);

            foreach (int i in fila)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
            fila.Enqueue(10);
            foreach (int i in fila)
            {
                Console.WriteLine(i);
            }
        } // Fecha a classe LeituraDeArquivo
        
        public void Lifo()
        {
            Console.WriteLine("Esse é o nosso Stack = LIFO (Last In, First Out)");
            Stack<int> pilha = new Stack<int>();
            pilha.Push(2);
            pilha.Push(4);
            pilha.Push(6);
            pilha.Push(8);

            foreach (int i in pilha)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
        }
    } // Fecha o namespace
}

