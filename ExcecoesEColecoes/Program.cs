﻿using ExcecoesEColecoes.models;

// Exemplos de Exceções e Coleções
Console.WriteLine("=== Exemplos de Exceções e Coleções ===");

// 1. Introdução Exceções
var exemplo1 = new IntroducaoExcecoes();
exemplo1.Executar();

// 2. Realizando a leitura de um arquivo
var exemplo2 = new RealizandoALeituraDeUmArquivo();
exemplo2.Executar();

// 3. Disparando uma Exceção
var exemplo3 = new DisparandoUmaExcecao();
exemplo3.Executar();

// 4. Tratando uma Exceção
var exemplo4 = new TratandoUmaExcecao();
exemplo4.Executar();

// 5. Exceção genérica e específica
var exemplo5 = new ExcecaoGenericaEEspecifica();
exemplo5.Executar();

// 6. Entendendo o bloco finally
var exemplo6 = new EntendendoOBlocoFinally();
exemplo6.Executar();

// 7. Usando o throw
//var exemplo7 = new UsandoOThrow();
//exemplo7.Executar();

// 8. Introdução a Filas
var exemplo8 = new IntroducaoAFilas();
exemplo8.Executar();

// 9. Fila na prática
var exemplo9 = new FilaNaPratica();
exemplo9.Executar();

// 10. Introdução a pilhas
var exemplo10 = new IntroducaoAPilhas();
exemplo10.Executar();

// 11. Pilhas na prática
var exemplo11 = new PilhasNaPratica();
exemplo11.Executar();

// 12. Introdução dictionary
var exemplo12 = new IntroducaoADictionary();
exemplo12.Executar();

// 13. Removendo e alterando elementos
var exemplo13 = new RemovendoEAlterandoElementos();
exemplo13.Executar();

// 14. Desafio Final
var desafio = new DesafioFinal();
desafio.Executar();

//Meu teste
var TestarF = new LeituraDeArquivo();
TestarF.Fifo();

var TestarL = new LeituraDeArquivo();
TestarL.Lifo();

