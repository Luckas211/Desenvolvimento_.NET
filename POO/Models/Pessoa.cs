/*
 * Pessoa_Documentacao_LinhaPorLinha.cs
 * -----------------------------------
 * Documentação linha-a-linha da classe Pessoa.
 * Cada comentário explica o papel da linha/trecho, os parâmetros
 * e as propriedades usadas. Feito para iniciantes — explicando
 * termos, retornos, exceções e boas práticas.
 *
 * Observação: este arquivo combina comentários normais (//)
 * com comentários XML (///) que são usados por ferramentas
 * como o Visual Studio para gerar ajuda automática.
 */

using System;                     // Importa tipos básicos do .NET (Console, Exception, String, etc.).
using System.Collections.Generic; // Importa coleções genéricas (List<T>, Dictionary<TKey,TValue>), *não utilizada neste arquivo*.
using System.Linq;               // Importa extensões LINQ para consultas sobre coleções, *não utilizada aqui*.
using System.Threading.Tasks;    // Importa tipos para programação assíncrona (Task), *não utilizada aqui*.

// É comum remover 'usings' não utilizados para manter o código limpo.

namespace POO.Models
{
    // XML comment para a classe. Ferramentas exibem esse texto ao passar o mouse.
    /// <summary>
    /// Representa uma Pessoa com informações básicas e comportamento para apresentação.
    /// </summary>
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public Pessoa()
        {

        }
        
        // -------------------------------------------------------------
        // Campos privados
        // -------------------------------------------------------------

        // Campo privado que armazena internamente o nome da pessoa.
        // Uso: manipulado apenas dentro da classe através da propriedade Nome.
        private string _nome;   // tipo: string (sequência de caracteres)

        // Campo privado que armazena internamente a idade da pessoa.
        // Uso: manipulado apenas dentro da classe através da propriedade Idade.
        private int _idade;     // tipo: int (inteiro)


        // -------------------------------------------------------------
        // Propriedade pública: Nome
        // -------------------------------------------------------------

        /// <summary>
        /// Propriedade pública para acessar e definir o nome da pessoa.
        /// GET: retorna o nome em letras maiúsculas.
        /// SET: valida se o valor não é vazio e armazena no campo interno _nome.
        /// </summary>
        /// <exception cref="ArgumentException">Lançada quando o valor informado é a string vazia ("").</exception>
        public string Nome
        {
            // GET: "get => _nome.ToUpper();" é uma forma curta (expression-bodied)
            // equivalente a: get { return _nome.ToUpper(); }
            // O operador => aqui significa "retornar o resultado da expressão".
            // Atenção: se _nome for null, _nome.ToUpper() lançará NullReferenceException.
            // Portanto, certifique-se de definir Nome antes de tentar lê-lo, ou
            // altere para: get => _nome == null ? string.Empty : _nome.ToUpper();
            get => _nome.ToUpper();

            // SET: o valor que está sendo atribuído fica disponível na variável implícita 'value'.
            // Ex.: pessoa.Nome = "Lucas";  => dentro do set, value == "Lucas".
            set
            {
                // Verifica se foi passada uma string vazia exatamente "".
                // Melhor prática: usar string.IsNullOrWhiteSpace(value) para cobrir null e espaços.
                if (value == "")
                {
                    // Lança uma exceção informando que a operação é inválida.
                    // ArgumentException é apropriada quando o argumento informado
                    // não atende às regras esperadas pelo método/propriedade.
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                // Se passou na validação, atribuímos o valor ao campo privado _nome.
                // Atribuição simples: armazena exatamente o texto recebido.
                _nome = value;
            }
        }


        // -------------------------------------------------------------
        // Propriedade pública: Idade
        // -------------------------------------------------------------

        /// <summary>
        /// Propriedade pública para acessar e definir a idade da pessoa.
        /// GET: retorna o valor inteiro armazenado em _idade.
        /// SET: valida se o valor não é negativo (menor que zero) e armazena em _idade.
        /// </summary>
        /// <exception cref="ArgumentException">Lançada quando value &lt; 0 (idade negativa).</exception>
        public int Idade
        {
            // GET: retorna o valor do campo privado _idade.
            get => _idade; // expression-bodied get -> equivalente a: get { return _idade; }

            // SET: valida se a idade informada é válida.
            set
            {
                // 'value' representa o número que está sendo atribuído, ex: pessoa.Idade = 25;
                // Aqui usamos uma validação simples: não permitir números negativos.
                if (value < 0)
                {
                    // Se a validação falhar, lançamos ArgumentException com uma mensagem amigável.
                    // Observação: a mensagem atual no código original diz "A idade não pode ser vazia.",
                    // que pode confundir; uma mensagem melhor seria "A idade não pode ser negativa.".
                    throw new ArgumentException("A idade não pode ser vazia.");
                }

                // Se válido, atribuímos ao campo privado.
                _idade = value;
            }
        }


        // -------------------------------------------------------------
        // Propriedade automática: Sobrenome
        // -------------------------------------------------------------

        /// <summary>
        /// Propriedade pública automática para o sobrenome da pessoa.
        /// Auto-property: o compilador cria um campo privado oculto por trás desta propriedade.
        /// GET e SET têm comportamento padrão (simples leitura e escrita).
        /// </summary>
        public string Sobrenome { get; set; }


        // -------------------------------------------------------------
        // Propriedade expression-bodied: NomeCompleto
        // -------------------------------------------------------------

        /// <summary>
        /// Propriedade somente-leitura que retorna o nome completo formatado.
        /// Implementada como expression-bodied (uso do =>). Retorna: "{Nome} {Sobrenome.ToUpper()}".
        /// </summary>
        /// <remarks>
        /// Observações importantes:
        /// - 'Nome' já retorna _nome.ToUpper(), então Nome e Sobrenome.ToUpper() estarão em maiúsculas.
        /// - Se Nome não tiver sido inicializado (ou seja, _nome == null), acessar NomeCompleto
        ///   pode resultar em NullReferenceException ao chamar ToUpper(). Veja validações acima.
        /// </remarks>
        public string NomeCompleto => $"{Nome} {Sobrenome.ToUpper()}";


        // -------------------------------------------------------------
        // Método público: Apresentar
        // -------------------------------------------------------------

        /// <summary>
        /// Método que escreve no console uma frase de apresentação da pessoa.
        /// </summary>
        /// <remarks>
        /// Não recebe parâmetros e não retorna valor (void). Usa internamente NomeCompleto e Idade.
        /// </remarks>
        public void Apresentar()
        {
            // Usa interpolação de strings ($"...") para inserir valores das propriedades diretamente.
            // Exemplo: $"Olá meu nome é: {NomeCompleto} e tenho: {Idade} anos.".
            Console.WriteLine($"Olá meu nome é: {NomeCompleto} e tenho: {Idade} anos.");
        }


        // -------------------------------------------------------------
        // Seções adicionais de documentação e boas práticas (dentro do arquivo para estudo)
        // -------------------------------------------------------------
        // - Sempre validar entradas: usar string.IsNullOrWhiteSpace(value) em vez de value == "" para
        //   evitar problemas com strings nulas ou contendo apenas espaços.
        // - Mensagens de exceção devem ser claras e condizentes com a validação realizada.
        //   Ex.: se você checa value < 0, a mensagem deve mencionar "negativa".
        // - Considere inicializar campos/auto-properties para evitar NullReferenceException.
        //   Ex.: private string _nome = string.Empty;  ou public string Sobrenome { get; set; } = string.Empty;
        // - Avalie o uso de propriedades somente-leitura (com private set) quando necessário restrição.
        // - Use comentários XML (///) para membros públicos para habilitar IntelliSense e geração de docs.

    }
}
