using ExemploFundamentos.Common.models;


DateTime DataAtual = DateTime.Now;
Console.WriteLine($"A data atual é: {DataAtual}");
Console.WriteLine($"---------------------------------------------------------------------------------Aula 1 - Entendendo os conceitos básicos");

// Aula 1 - Entendendo os conceitos básicos
// Criando uma instância da classe Pessoa e atribuindo valores às propriedades
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Lucas"; // Exemplo: Atribuindo uma string à propriedade Nome
pessoa1.Idade = 27; // Exemplo: Atribuindo um int à propriedade Idade
pessoa1.Apresentar(); // Chamando o método para exibir as informações
Console.WriteLine($"---------------------------------------------------------------------------------Aula 2 - Tipos de dados");
// Aula 2 - Tipos de dados
// Criando uma instância da classe TiposdeDados e demonstrando os tipos de dados
TiposdeDados representacao = new TiposdeDados();
representacao.Nome = "Lucas"; // string: Tipo de referência para texto
representacao.Nome = "Lucas Silva";
representacao.Idade = 27; // int: Tipo inteiro com sinal de 32 bits
representacao.Peso = 80.5f; // float: Tipo de ponto flutuante de precisão simples (32 bits)
representacao.Sexo = 'M'; // char: Tipo que representa um único caractere Unicode
representacao.Altura = 1.80; // double: Tipo de ponto flutuante de precisão dupla (64 bits)
representacao.Casado = true; // bool: Tipo booleano (verdadeiro ou falso)
representacao.Objeto = 123; // object: Tipo de referência base que pode armazenar qualquer tipo
representacao.Byte = 255; // byte: Tipo inteiro sem sinal de 8 bits (0 a 255)
representacao.Decimal = 123.4567890123456789m; // decimal: Tipo decimal de alta precisão (128 bits)
representacao.Long = 9223L; // long: Tipo inteiro com sinal de 64 bits
representacao.Short = 32767; // short: Tipo inteiro com sinal de 16 bits
representacao.UnsignedInt = 4294967295U; // uint: Tipo inteiro sem sinal de 32 bits
representacao.UnsignedLong = 18446744073709551615UL; // ulong: Tipo inteiro sem sinal de 64 bits
representacao.UnsignedShort = 65535; // ushort: Tipo inteiro sem sinal de 16 bits

// Chamando o método para exibir os valores das propriedades
representacao.Chamada();

Console.WriteLine($"---------------------------------------------------------------------------------Aula 3 - Operadores");
// Aula 3 - Operadores

Operadores adicao = new Operadores();
adicao.numero1 = 10;
adicao.numero2 = 20;
adicao.somar();

Operadores subtracao = new Operadores();
subtracao.numero1 = 10;
subtracao.numero2 = 20;
subtracao.subtrair();

Operadores multiplicacao = new Operadores();
multiplicacao.numero1 = 10;
multiplicacao.numero2 = 20;
multiplicacao.multiplicar();

Operadores divisao = new Operadores();
divisao.numero1 = 3;
divisao.numero2 = 2;
divisao.dividir();

Console.WriteLine($"---------------------------------------------------------------------------------Aula 3 - Operadores - Parte 2");

// Instanciando Operadores para novos métodos
Operadores operadoresAvancados = new Operadores();

operadoresAvancados.IntroducaoAtribuicao();
operadoresAvancados.CombinandoOperadores();
operadoresAvancados.ConvertendoTipos();
operadoresAvancados.DiferencaConvertParse();
operadoresAvancados.ConversaoParaString();
operadoresAvancados.CastImplicito();
operadoresAvancados.OrdemOperadores();
operadoresAvancados.ConversaoSegura();

Console.WriteLine($"---------------------------------------------------------------------------------Aula 4 - Operadores Lógicos");

// Aula 4 - Operadores Lógicos
OperadoresLogicos Logicos = new OperadoresLogicos();
Logicos.QuantidadeEmEstoque = 100;
Logicos.QuantidadeCompra = 50;
Logicos.VerificarVenda();

Console.WriteLine($"---------------------------------------------------------------------------------Introdução aos Operadores Lógicos");
Logicos.IntroducaoOperadoresLogicos();

Console.WriteLine($"---------------------------------------------------------------------------------Operador OR na Prática");
Logicos.OperadorORNaPratica();

Console.WriteLine($"---------------------------------------------------------------------------------Introdução ao Operador AND");
Logicos.IntroducaoOperadorAND();

Console.WriteLine($"---------------------------------------------------------------------------------Introdução ao Operador NOT");
Logicos.IntroducaoOperadorNOT();

Console.WriteLine($"---------------------------------------------------------------------------------Operador NOT na Prática");
Logicos.OperadorNOTNaPratica();



// Console.WriteLine($"---------------------------------------------------------------------------------Aula 5 - Operadores Condicionais");
// // Aula 5 - Operadores Condicionais
// OperadoresCondicionais condicionais = new OperadoresCondicionais();

// Console.WriteLine($"---------------------------------------------------------------------------------Introdução aos Operadores Condicionais");
// condicionais.IntroducaoOperadoresCondicionais();

// Console.WriteLine($"---------------------------------------------------------------------------------Operador Condicional na Prática (com Debugging)");
// condicionais.OperadorCondicionalNaPratica();

// Console.WriteLine($"---------------------------------------------------------------------------------If Alinhado (Nested If)");
// condicionais.IfAlinhado();

// Console.WriteLine($"---------------------------------------------------------------------------------Aprendendo Switch Case");
// condicionais.AprendendoSwitchCase();

Console.WriteLine($"---------------------------------------------------------------------------------Aula 5 - Operadores Aritméticos");
// Aula 5 - Operadores Aritméticos

OperadoresAritimeticos aritimeticos = new OperadoresAritimeticos();



aritimeticos.somar(10, 20);
aritimeticos.subtrair(20, 10);
aritimeticos.multiplicar(5, 2);
aritimeticos.dividir(5, 2);

Console.WriteLine("---------------------------------------------------------------------------------Utilizando a biblioteca Math");
//Utilizando a class Math Potencias
aritimeticos.Potencia(2, 3);
//Utilizando a class Math Seno
aritimeticos.Seno(30);
//Utilizando a class Math Cosseno
aritimeticos.Cosseno(30);
//Utilizando a class Math Tangente
aritimeticos.Tangente(30);
//Utilizando a class Math Raiz quadrada
aritimeticos.RaizQuadrada(9);

Console.WriteLine("---------------------------------------------------------------------------------Incrementação e decrementação de valores");
//Incrementando valores
aritimeticos.Incrementando(15);
//Decrementando valores
aritimeticos.decrementando(10);


Console.WriteLine("---------------------------------------------------------------------------------Aula 6 - Estruturas de Repetição");
// Aula 6 - Estruturas de Repetição
EstruturaDeRepeticao Estrutura = new EstruturaDeRepeticao();
Console.WriteLine("---------------------------------------------------------------------------------Testando o For");
Estrutura.TestandoFor(7);
//Estrutura.TestandoWhile(1);
Console.WriteLine("---------------------------------------------------------------------------------Testando o While");
Estrutura.TestandoWhile(5);
Console.WriteLine("---------------------------------------------------------------------------------Testando o DoWhile");
//Estrutura.TestandoDoWhile();
Console.WriteLine("---------------------------------------------------------------------------------Testando o Menu interativo");
//Estrutura.MenuInterativo();
























