using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NugetSerializarAtributos.models
{
    public class SerializarPratica
    {
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")] // Isso faz com que no JSON apareça "Nome_Produto"
        public string Produto { get; set; } = string.Empty; // Inicializado para evitar warnings

        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        public void ConverterEmJson(List<SerializarPratica> listaProdutos)
        {
            string json = JsonConvert.SerializeObject(listaProdutos, Formatting.Indented);
            Directory.CreateDirectory("Arquivos");
            File.WriteAllText("Arquivos/Produtos.json", json);
            Console.WriteLine(json);
        }
    }
}
