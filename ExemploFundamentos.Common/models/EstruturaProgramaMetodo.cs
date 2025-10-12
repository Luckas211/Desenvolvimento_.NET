using System;

namespace ExemploFundamentos.Common.models

{
    /// <summary>
    /// Classe dedicada a explicar a estrutura de um programa C#, criação de projetos,
    /// organização, referências, diferenças entre .NET 5 e .NET 6, e caminhos no terminal.
    /// Esta classe serve como material didático, conectando conceitos teóricos aos arquivos do projeto.
    /// </summary>
    public class EstruturaProgramaMetodo
    {
        // ====================================================================================================
        // 1. ESTRUTURA DE UM PROGRAMA C#
        // ====================================================================================================

        /// <summary>
        /// Explica a estrutura básica de um programa C#.
        /// Um programa C# típico é composto por:
        /// - Diretivas using: Para importar namespaces e tornar tipos acessíveis.
        /// - Namespace: Agrupa classes relacionadas e evita conflitos de nomes.
        /// - Classe: Contém métodos e propriedades; o ponto de entrada é a classe com Main.
        /// - Método Main: Ponto de entrada do programa (static void Main(string[] args)).
        /// - Instruções: Código executável dentro de métodos.
        ///
        /// Exemplo no projeto: Program.cs
        /// - Using: using Manual_de_Estudo_.NET.models; (importa o namespace dos modelos)
        /// - Namespace implícito (gerado pelo .csproj com ImplicitUsings)
        /// - Classe implícita (Program é a classe padrão)
        /// - Main: Contém instâncias de classes como Pessoa, TiposdeDados, etc.
        ///
        /// Conexão: O .csproj define <ImplicitUsings>enable</ImplicitUsings>, que adiciona usings comuns automaticamente,
        /// evitando a necessidade de declarar using System; manualmente em Program.cs.
        /// </summary>
        public static void ExplicarEstruturaPrograma()
        {
            Console.WriteLine("1. Estrutura de um Programa C#:");
            Console.WriteLine("- Diretivas using: Importam namespaces.");
            Console.WriteLine("- Namespace: Organiza o código.");
            Console.WriteLine("- Classe: Contém lógica.");
            Console.WriteLine("- Método Main: Ponto de entrada.");
            Console.WriteLine("Exemplo: Program.cs instancia classes de models/ e chama métodos.");
        }

        // ====================================================================================================
        // 2. CRIANDO NOSSO NOVO PROJETO
        // ====================================================================================================

        /// <summary>
        /// Explica como criar um novo projeto .NET.
        /// Passos:
        /// 1. Instalar .NET SDK (dotnet --version para verificar).
        /// 2. Usar 'dotnet new console' para criar um projeto de console.
        /// 3. Adicionar arquivos .cs no diretório.
        /// 4. Compilar com 'dotnet build'.
        /// 5. Executar com 'dotnet run'.
        ///
        /// Exemplo no projeto atual:
        /// - Criado com 'dotnet new console --name "Manual de Estudo .NET"'.
        /// - Arquivos: Program.cs (principal), models/*.cs (classes auxiliares).
        /// - .csproj gerado automaticamente com configurações básicas.
        ///
        /// Conexão: O .csproj (<OutputType>Exe</OutputType>) indica que é um executável,
        /// permitindo 'dotnet run' para executar Program.cs.
        /// </summary>
        public static void ExplicarCriacaoProjeto()
        {
            Console.WriteLine("2. Criando nosso Novo Projeto:");
            Console.WriteLine("- Instalar .NET SDK.");
            Console.WriteLine("- dotnet new console --name 'NomeDoProjeto'.");
            Console.WriteLine("- Adicionar código em Program.cs.");
            Console.WriteLine("- dotnet build e dotnet run.");
            Console.WriteLine("Exemplo: Este projeto foi criado assim, com models/ para organizar classes.");
        }

        // ====================================================================================================
        // 3. ORGANIZANDO E REFERENCIANDO PROJETOS
        // ====================================================================================================

        /// <summary>
        /// Explica organização de projetos e referências.
        /// - Solução (.sln): Agrupa múltiplos projetos.
        /// - Projetos (.csproj): Definem dependências, frameworks, etc.
        /// - Referências: Usar <ProjectReference> para linkar projetos.
        /// - Estrutura de pastas: models/ para classes, bin/ para builds.
        ///
        /// Exemplo no projeto:
        /// - .sln: Contém o projeto "Manual de Estudo .NET".
        /// - models/: Classes como Pessoa.cs, usadas em Program.cs via using.
        /// - Sem referências externas, mas se houvesse, adicionaria <PackageReference> no .csproj.
        ///
        /// Conexão: O namespace Manual_de_Estudo_.NET.models permite acesso às classes,
        /// e o .csproj define <RootNamespace> para consistência.
        /// </summary>
        public static void ExplicarOrganizacaoReferencias()
        {
            Console.WriteLine("3. Organizando e Referenciando Projetos:");
            Console.WriteLine("- .sln: Agrupa projetos.");
            Console.WriteLine("- .csproj: Configura build e dependências.");
            Console.WriteLine("- Pastas: models/ para lógica separada.");
            Console.WriteLine("Exemplo: Program.cs referencia models/ via using e instancia classes.");
        }

        // ====================================================================================================
        // 4. CRIANDO UM PROJETO EM .NET 5 E .NET 6
        // ====================================================================================================

        /// <summary>
        /// Explica criação de projetos em .NET 5 e .NET 6.
        /// - .NET 5: LTS, unificado para desktop, web, mobile.
        /// - .NET 6: LTS, melhor performance, minimal APIs.
        /// Passos:
        /// 1. dotnet new console --framework net5.0 (para .NET 5).
        /// 2. Ou --framework net6.0 (para .NET 6).
        /// 3. No .csproj: <TargetFramework>net5.0</TargetFramework> ou net6.0.
        ///
        /// Exemplo: Este projeto usa net9.0, mas para net5.0/net6.0, altere <TargetFramework>.
        /// Para migrar: dotnet new console --framework net6.0 --name NovoProjeto.
        ///
        /// Conexão: O .csproj controla o framework; alterar requer rebuild.
        /// </summary>
        public static void ExplicarCriacaoNet5Net6()
        {
            Console.WriteLine("4. Criando um Projeto em .NET 5 e .NET 6:");
            Console.WriteLine("- .NET 5: dotnet new console --framework net5.0");
            Console.WriteLine("- .NET 6: dotnet new console --framework net6.0");
            Console.WriteLine("- Alterar <TargetFramework> no .csproj.");
            Console.WriteLine("Exemplo: Este projeto é net9.0; para net5/6, especifique framework.");
        }

        // ====================================================================================================
        // 5. COMPARANDO .NET 5 E .NET 6
        // ====================================================================================================

        /// <summary>
        /// Compara .NET 5 e .NET 6.
        /// - .NET 5: Introduziu unificação, performance melhorada, C# 9.
        /// - .NET 6: Melhor ainda em performance (50% mais rápido), minimal APIs para web,
        ///   suporte a ARM64, hot reload aprimorado, .NET MAUI para cross-platform.
        /// Diferenças:
        /// - .NET 5: Foco em unificação.
        /// - .NET 6: Foco em produtividade e performance.
        /// Ambos LTS, mas .NET 6 é mais recente e recomendado.
        ///
        /// Exemplo: Este projeto em net9.0 herda melhorias de ambos.
        /// Para comparar: Criar dois projetos e medir performance com BenchmarkDotNet.
        ///
        /// Conexão: O .csproj define o framework; escolher baseado em necessidades.
        /// </summary>
        public static void CompararNet5Net6()
        {
            Console.WriteLine("5. Comparando .NET 5 e .NET 6:");
            Console.WriteLine("- .NET 5: Unificação, C# 9.");
            Console.WriteLine("- .NET 6: Performance 50% melhor, minimal APIs, MAUI.");
            Console.WriteLine("- Ambos LTS; .NET 6 mais avançado.");
            Console.WriteLine("Exemplo: net9.0 inclui evoluções; teste performance em projetos separados.");
        }

        // ====================================================================================================
        // 6. ENTENDENDO O CAMINHO NO TERMINAL
        // ====================================================================================================

        /// <summary>
        /// Explica caminhos no terminal.
        /// - pwd: Mostra diretório atual (Print Working Directory).
        /// - cd: Muda diretório (Change Directory), e.g., cd models/.
        /// - ls/dir: Lista arquivos.
        /// - ./ : Diretório atual.
        /// - ../ : Diretório pai.
        /// - Caminhos absolutos: C:/Users/... (Windows) ou /home/... (Linux).
        ///
        /// Exemplo no projeto:
        /// - pwd: c:/Users/Administrator/Documents/Manual de Estudo .NET
        /// - cd models: Entra na pasta models/.
        /// - dotnet run: Executa de qualquer lugar se no diretório do .csproj.
        ///
        /// Conexão: O .csproj e .sln estão na raiz; comandos dotnet funcionam relativo ao .csproj.
        /// </summary>
        public static void ExplicarCaminhoTerminal()
        {
            Console.WriteLine("6. Entendendo o Caminho no Terminal:");
            Console.WriteLine("- pwd: Diretório atual.");
            Console.WriteLine("- cd: Muda diretório.");
            Console.WriteLine("- ls/dir: Lista arquivos.");
            Console.WriteLine("- ./ : Atual; ../ : Pai.");
            Console.WriteLine("Exemplo: De c:/.../Manual de Estudo .NET, dotnet build compila o projeto.");
        }

        /// <summary>
        /// Método principal para demonstrar todas as explicações.
        /// Chame este método para ver as saídas no console.
        /// </summary>
        public static void DemonstrarEstrutura()
        {
            ExplicarEstruturaPrograma();
            Console.WriteLine();
            ExplicarCriacaoProjeto();
            Console.WriteLine();
            ExplicarOrganizacaoReferencias();
            Console.WriteLine();
            ExplicarCriacaoNet5Net6();
            Console.WriteLine();
            CompararNet5Net6();
            Console.WriteLine();
            ExplicarCaminhoTerminal();
        }
    }
}
