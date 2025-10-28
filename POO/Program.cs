﻿using POO.Models;

// Exemplos de Orientação a Objetos com Pessoa e Curso
Pessoa p1 = new Pessoa();
p1.Nome = "Lucas";
p1.Sobrenome = "Silva";
p1.Idade = 27;

Pessoa p2 = new Pessoa();
p2.Nome = "Bruna";
p2.Sobrenome = "Silva";
p2.Idade = 28;

Pessoa p3 = new Pessoa(nome: "João", sobrenome: "Silva");

Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Curso de Inglês";
CursoDeIngles.Alunos = new List<Pessoa>();
CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.AdicionarAluno(p3);
CursoDeIngles.ListarAlunos();

// Exemplos de Fundamentos .NET
Console.WriteLine("=== Exemplos de Fundamentos .NET ===");

// 1. Introdução Manipulando Valores
var exemplo1 = new IntroducaoManipulandoValores();
exemplo1.Executar();

// 2. Concatenando Strings
var exemplo2 = new ConcatenandoStrings();
exemplo2.Executar();

// 3. Interpolação de Strings
var exemplo3 = new InterpolacaoDeStrings();
exemplo3.Executar();

// 4. Ajustando Numeração
var exemplo4 = new AjustandoNumeracao();
exemplo4.Executar();

// 5. Concatenação de Valores
var exemplo5 = new ConcatenacaoDeValores();
exemplo5.Executar();

// 6. Formatando Valores Monetários
var exemplo6 = new FormatandoValoresMonetarios();
exemplo6.Executar();

// 7. Alterando Localização do Código
var exemplo7 = new AlterandoLocalizacaoDoCodigo();
exemplo7.Executar();

// 8. Alterando Localização da Cultura
var exemplo8 = new AlterandoLocalizacaoDaCultura();
exemplo8.Executar();

// 9. Formatação Personalizada
var exemplo9 = new FormatacaoPersonalizada();
exemplo9.Executar();

// 10. Representando Porcentagem
var exemplo10 = new RepresentandoPorcentagem();
exemplo10.Executar();

// 11. Formatando Data e Hora
var exemplo11 = new FormatandoDataEHora();
exemplo11.Executar();

// 12. DateTime com TryParse
var exemplo12 = new DateTimeComTryParse();
exemplo12.Executar();

// 13. Validando o Retorno do TryParse
var exemplo13 = new ValidandoRetornoDoTryParse();
exemplo13.Executar();


Lista lista = new Lista();

lista.AdicionarElementos();
lista.ListarElementos();

