// Importa bibliotecas (namespaces) necessárias para o funcionamento do código
using System;                        // Fornece funcionalidades básicas (ex: Console, Exception, etc.)
using System.Collections.Generic;    // Permite o uso de coleções genéricas, como List<T>
using System.Linq;                   // Fornece métodos de consulta LINQ (como Count())
using System.Threading.Tasks;        // Fornece suporte para programação assíncrona (Task, async, await)
using System.IO;                     // Necessário para operações de leitura e escrita de arquivos

// Define o namespace (um agrupamento lógico de classes)
// Aqui ele ajuda a organizar o código dentro de um "pacote" chamado TuplasOperadorDescontrucaoObjeto.models
namespace TuplasOperadorDescontrucaoObjeto.models
{
    // Define uma classe pública chamada TuplaEmMetodos
    // Essa classe conterá métodos que trabalham com tuplas e leitura de arquivos
    public class TuplaEmMetodos
    {
        // Declaração de um método público chamado LerArquivo
        // Esse método recebe um parâmetro "Caminho" (string) representando o caminho do arquivo a ser lido
        // Ele retorna uma tupla (conjunto de múltiplos valores) com:
        // - bool Sucesso → indica se a leitura deu certo (true ou false)
        // - string[] Linhas → o conteúdo do arquivo dividido por linhas
        // - int QuantidadeLinhas → a quantidade total de linhas lidas
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string Caminho)
        {
            try
            {
                // Tenta executar o bloco abaixo.
                // Se algo der errado (ex: arquivo não encontrado), o programa vai pular direto pro catch.

                // Lê todas as linhas do arquivo especificado pelo caminho e armazena no array 'linhas'
                // File.ReadAllLines(Caminho) → lê o arquivo inteiro e retorna um array de strings (cada elemento é uma linha)
                string[] linhas = File.ReadAllLines(Caminho);

                // Retorna uma tupla com 3 valores:
                // 1. true → indica que deu certo
                // 2. linhas → o conteúdo do arquivo
                // 3. linhas.Count() → a quantidade de linhas lidas (usando LINQ)
                //
                // Essa linha "fecha" a execução do método, enviando a tupla de volta para quem chamou.
                return (true, linhas, linhas.Count());
            }
            catch (Exception ex)
            {
                // Esse bloco será executado SE ocorrer uma exceção (erro) dentro do bloco try.
                // Por exemplo: se o arquivo não existir, ou o caminho estiver incorreto.

                // Retorna uma tupla indicando falha na leitura:
                // 1. false → leitura falhou
                // 2. new string[0] → cria um array vazio de strings (sem linhas)
                // 3. 0 → quantidade de linhas é zero
                return (false, new string[0], 0);

                // OBS: A variável 'ex' armazena os detalhes do erro ocorrido.
                // Ela não está sendo usada aqui, mas poderia ser usada, por exemplo, para logar o erro:
                // Console.WriteLine(ex.Message);
            }
        }
    }
}
