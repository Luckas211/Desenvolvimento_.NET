using System; // Importa o namespace System para usar classes como Console
using System.Collections.Generic; // Importa o namespace System.Collections.Generic para usar classes como Queue
using System.IO; // Importa o namespace System.IO para usar classes como File

namespace ExcecoesEColecoes.models // Define o namespace para organizar as classes
{
    /// <summary>
    /// Classe para o desafio final: combina exceções e coleções.
    /// Exemplo: sistema de processamento de tarefas de um arquivo, usando fila, com tratamento de erros.
    /// Desafio: Ler tarefas de um arquivo, adicionar a uma fila, processar com exceções se inválidas.
    /// </summary>
    public class DesafioFinal // Declara uma classe pública chamada DesafioFinal
    {
        /// <summary>
        /// Método que executa o desafio final.
        /// </summary>
        public void Executar() // Declara um método público sem retorno chamado Executar
        {
            Console.WriteLine("=== 14. Desafio Final: Sistema de Processamento de Tarefas ==="); // Escreve uma mensagem no console indicando o início do desafio

            string caminhoArquivo = "Arquivos/ArquivoLeitura.txt"; // Declara uma string com o caminho do arquivo
            Queue<string> filaTarefas = new Queue<string>(); // Declara e inicializa uma Queue de strings para tarefas

            try // Inicia um bloco try para tentar executar código que pode lançar exceções
            {
                // Lê o arquivo (tópico 2)
                string[] linhas = File.ReadAllLines(caminhoArquivo); // Lê todas as linhas do arquivo e armazena em um array

                // Adiciona tarefas à fila (tópicos 8-9)
                foreach (string linha in linhas) // Itera sobre cada linha do arquivo
                {
                    filaTarefas.Enqueue(linha); // Adiciona a linha à fila
                }

                Console.WriteLine("Tarefas carregadas na fila:"); // Escreve uma mensagem no console
                foreach (string tarefa in filaTarefas) // Itera sobre cada tarefa na fila
                {
                    Console.WriteLine($"- {tarefa}"); // Escreve a tarefa no console
                }

                // Processa a fila
                while (filaTarefas.Count > 0) // Enquanto houver tarefas na fila
                {
                    string tarefa = filaTarefas.Dequeue(); // Remove e obtém a primeira tarefa da fila

                    try // Inicia um bloco try interno para processamento individual
                    {
                        // Simula processamento: se tarefa contém "Lucas", sucesso; senão, exceção
                        if (tarefa.Contains("Lucas")) // Verifica se a tarefa contém "Lucas"
                        {
                            Console.WriteLine($"Processando tarefa: {tarefa} - Sucesso!"); // Escreve sucesso no console
                        }
                        else
                        {
                            // Dispara exceção (tópicos 3,7)
                            throw new InvalidOperationException($"Tarefa inválida: {tarefa}"); // Lança uma InvalidOperationException
                        }
                    }
                    catch (InvalidOperationException ex) // Captura especificamente a InvalidOperationException
                    {
                        // Trata exceção específica (tópicos 4,5)
                        Console.WriteLine($"Erro ao processar: {ex.Message}"); // Escreve a mensagem de erro no console
                    }
                    finally // Bloco que sempre executa, independente de exceção
                    {
                        // Bloco finally sempre executa (tópico 6)
                        Console.WriteLine("Tarefa processada (sucesso ou erro)."); // Escreve mensagem no console
                    }
                }
            }
            catch (FileNotFoundException ex) // Captura especificamente a FileNotFoundException
            {
                // Exceção genérica para arquivo (tópico 5)
                Console.WriteLine($"Arquivo não encontrado: {ex.Message}"); // Escreve a mensagem de erro no console
            }
            catch (Exception ex) // Captura qualquer outra exceção
            {
                Console.WriteLine($"Erro geral: {ex.Message}"); // Escreve a mensagem de erro no console
            }

            Console.WriteLine("Desafio final concluído: sistema processou tarefas com exceções e coleções."); // Escreve mensagem de conclusão
            Console.WriteLine(); // Escreve uma linha em branco no console
        } // Fecha o método Executar
    } // Fecha a classe DesafioFinal
} // Fecha o namespace
