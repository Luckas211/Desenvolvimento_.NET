using System;

namespace TuplasOperadorDescontrucaoObjeto.models
{
    // Classe de exemplo para demonstrar o uso de desconstrutor em C#
    public class Desconstrutor
    {
        // Propriedades da classe
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }

        // Construtor da classe - executado quando criamos uma nova instância (objeto)
        public Desconstrutor(string nome, int idade, string profissao)
        {
            Nome = nome;
            Idade = idade;
            Profissao = profissao;
        }

        // 🔹 MÉTODO DESCONSTRUTOR 🔹
        // Ele serve para "desmontar" o objeto em variáveis separadas
        // Isso permite atribuir cada propriedade a uma variável individual facilmente.
        public void Deconstruct(out string nome, out int idade, out string profissao)
        {
            nome = this.Nome;
            idade = this.Idade;
            profissao = this.Profissao;
        }

        // Método auxiliar para exibir as informações do objeto
        public void MostrarInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Profissão: {Profissao}");
        }
    }
}
