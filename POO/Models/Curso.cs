/*
 * Curso_Documentacao_LinhaPorLinha.cs
 * -----------------------------------
 * Documentação linha-a-linha da classe Curso.
 * Explica cada linha, propriedade, método, parâmetro e uso das listas.
 * Feito para iniciantes entenderem passo a passo.
 */

using System;                     // Importa tipos básicos do .NET (Console, String, Exception, etc.)
using System.Collections.Generic; // Importa coleções genéricas (List<T>), usada para armazenar os alunos.
using System.Linq;                // Importa LINQ (não utilizado diretamente neste arquivo, mas útil para manipular listas futuramente).
using System.Threading.Tasks;     // Importa tipos de tarefas assíncronas (não utilizados aqui, mas mantido para fins educacionais).

namespace POO.Models
{
    // 🔹 Classe Curso
    /// <summary>
    /// Representa um curso que possui um nome e uma lista de alunos matriculados.
    /// Contém métodos para adicionar, remover, contar e listar alunos no console.
    /// </summary>
    public class Curso
    {
        // -------------------------------------------------------------
        // Propriedades
        // -------------------------------------------------------------

        /// <summary>
        /// Nome do curso.
        /// <para>Exemplo: "Curso de Inglês" ou "Programação em C#".</para>
        /// </summary>
        public string Nome { get; set; } = string.Empty; // Inicializado para evitar null

        /// <summary>
        /// Lista contendo os alunos matriculados neste curso.
        /// <para>Tipo: List&lt;Pessoa&gt; — armazena objetos do tipo Pessoa.</para>
        /// </summary>
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>(); 
        // Inicializa a lista para evitar NullReferenceException caso métodos sejam chamados antes de adicionar alunos.

        // -------------------------------------------------------------
        // Métodos
        // -------------------------------------------------------------

        /// <summary>
        /// Adiciona um aluno à lista de alunos do curso.
        /// </summary>
        /// <param name="aluno">Objeto do tipo <see cref="Pessoa"/> a ser adicionado à lista.</param>
        /// <exception cref="ArgumentNullException">Lançada se o parâmetro 'aluno' for nulo.</exception>
        public void AdicionarAluno(Pessoa aluno)
        {
            // Verifica se o objeto aluno é nulo antes de adicionar.
            if (aluno == null)
            {
                throw new ArgumentNullException(nameof(aluno), "O aluno não pode ser nulo.");
            }

            // Adiciona o aluno à lista.
            Alunos.Add(aluno);
        }

        /// <summary>
        /// Retorna a quantidade de alunos matriculados no curso.
        /// </summary>
        /// <returns>Inteiro representando o número de alunos na lista.</returns>
        public int QuantidadeAlunosMatriculados()
        {
            // 'Count' retorna o número de elementos na lista Alunos.
            return Alunos.Count;
        }

        /// <summary>
        /// Remove um aluno da lista de alunos do curso.
        /// </summary>
        /// <param name="aluno">Objeto do tipo <see cref="Pessoa"/> a ser removido.</param>
        /// <returns>Verdadeiro (true) se o aluno foi removido com sucesso; falso (false) caso contrário.</returns>
        /// <exception cref="ArgumentNullException">Lançada se o parâmetro 'aluno' for nulo.</exception>
        public bool RemoverAluno(Pessoa aluno)
        {
            if (aluno == null)
            {
                throw new ArgumentNullException(nameof(aluno), "O aluno não pode ser nulo.");
            }

            // O método Remove retorna true se encontrou e removeu o objeto, ou false se não encontrou.
            return Alunos.Remove(aluno);
        }

        /// <summary>
        /// Lista todos os alunos matriculados no curso no console, mostrando nome e posição.
        /// </summary>
        public void ListarAlunos()
        {
            // Cabeçalho para exibição no console.
            Console.WriteLine($"Alunos do curso: {Nome}");
            Console.WriteLine("-----------------------------------");

            // Se a lista estiver vazia, informa o usuário e encerra o método.
            if (Alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno matriculado ainda.\n");
                return;
            }

            // Percorre a lista de alunos usando for para mostrar também o índice (posição).
            for (int i = 0; i < Alunos.Count; i++)
            {
                // Exibe a posição (i+1 para numerar a partir de 1) e o nome completo do aluno.
                Console.WriteLine($"Aluno Nº {i + 1}: {Alunos[i].NomeCompleto}");
            }

            // Exibe a quantidade total de alunos matriculados.
            Console.WriteLine($"\nTotal de alunos: {QuantidadeAlunosMatriculados()}");
            Console.WriteLine("-----------------------------------\n");
        }

        // -------------------------------------------------------------
        // Boas práticas e observações
        // -------------------------------------------------------------
        // ✅ Sempre inicializar listas (evita erros de referência nula).
        // ✅ Validar parâmetros de entrada (evita exceções inesperadas).
        // ✅ Métodos Count, Add, Remove e laços for/foreach são essenciais para manipular coleções em C#.
        // ✅ A documentação XML (///) é interpretada pelo Visual Studio, gerando descrições automáticas.
        // ✅ O método ListarAlunos() poderia futuramente retornar uma string ou lista, para uso em interfaces gráficas.
    }
}
