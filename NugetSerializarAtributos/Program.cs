using NugetSerializarAtributos.models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json; // Corrigido: o nome correto é 'Newtonsoft.Json'

// Cria uma lista de produtos
List<SerializarPratica> ListaProdutos = new List<SerializarPratica>();

// Adiciona os produtos à lista (com a data e hora atual)
ListaProdutos.Add(new SerializarPratica { Id = 1, Nome_Produto = "Arroz", Preco = 24.55M, DataVenda = DateTime.Now });
ListaProdutos.Add(new SerializarPratica { Id = 2, Nome_Produto = "Macarrão", Preco = 5.58M, DataVenda = DateTime.Now });

// Cria uma instância só para chamar o método
var converter = new SerializarPratica();
converter.ConverterEmJson(ListaProdutos);

Console.WriteLine("\n--- Deserializando o JSON ---\n");

// Cria uma instância da classe responsável pela leitura
var leitor = new DeserializarObjeto();
leitor.Deserializando();
