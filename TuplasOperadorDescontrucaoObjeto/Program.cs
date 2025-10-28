using System;
using TuplasOperadorDescontrucaoObjeto.models;


        Console.WriteLine("-----------------------------------------Exemplo 1");
        var tupla = new Tuplas();
        tupla.TuplaBasica();

        Console.WriteLine("-----------------------------------------Exemplo 2");
        var tupla2 = new Tuplas();
        tupla2.ExemploTupla2();

        Console.WriteLine("-----------------------------------------Exemplo 3");
        var tupla3 = new Tuplas();
        tupla3.ExemploTupla3();

        Console.WriteLine("-----------------------------------------Exemplo 4");
        var tupla4 = new Tuplas();
        tupla4.ExemploTupla4();

        Console.WriteLine("-----------------------------------------Tupla em Métodos");
        var arquivo = new TuplaEmMetodos();

        // Chama o método que lê um arquivo e retorna uma tupla
        var (Sucesso, Linhas, QuantidadeLinhas) = arquivo.LerArquivo("Arquivos/ArquivoLeitura.txt");

        // Se não for utilizar uma das informações, basta usar "_"
        // Exemplo: var (Sucesso, Linhas, _) = arquivo.LerArquivo("...");

        if (Sucesso)
        {
            Console.WriteLine($"Quantidade de linhas: {QuantidadeLinhas}");
            foreach (string linha in Linhas)
            {
                Console.WriteLine(linha);
            }
        }
        else
        {
            Console.WriteLine("Erro ao ler o arquivo.");
        }

        // ---------------------------------------------------------------------
        Console.WriteLine("-----------------------------------------Exemplo de Desconstrutor");

        // Cria uma nova instância da classe Desconstrutor
        Desconstrutor pessoa = new Desconstrutor("Lucas", 27, "Desenvolvedor");

        // Mostra os dados antes de desconstruir
        Console.WriteLine("== Exibindo informações do objeto original ==");
        pessoa.MostrarInformacoes();

        // 🔹 Agora ocorre a desconstrução
        // A linha abaixo chama automaticamente o método Deconstruct()
        var (nome, idade, profissao) = pessoa;

        Console.WriteLine("\n== Após desconstruir o objeto ==");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Profissão: {profissao}");

        // Você pode até usar os valores desconstruídos em outras operações
        Console.WriteLine($"\n{nome} tem {idade} anos e trabalha como {profissao}.");

Console.WriteLine("-----------------------------------------Exemplo If Ternário");

var ifTenario = new IfTenario();

// Exemplo 1
ifTenario.ExemploBasico();

// Exemplo 2
ifTenario.ExemploComEntradaDoUsuario();

// Exemplo 3
ifTenario.ExemploAninhado();
