using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NugetSerializarAtributos.models
{
    public class DeserializarObjeto
    {
        // Método responsável por ler e converter o JSON em objetos
        public void Deserializando()
        {
            // Caminho do arquivo
        string Caminho = File.ReadAllText("Arquivos/Produtos.json");
            List<SerializarPratica> listaProdutos = JsonConvert.DeserializeObject<List<SerializarPratica>>(Caminho);
            
            // Exibe no console os produtos
            Console.WriteLine("Produtos carregados do JSON:\n");
            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"ID: {produto.Id}");
                Console.WriteLine($"Produto: {produto.Produto}");
                Console.WriteLine($"Preço: R${produto.Preco}");
                Console.WriteLine($"Data da Venda: {produto.DataVenda}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
