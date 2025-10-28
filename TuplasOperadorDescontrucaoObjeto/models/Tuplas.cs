using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuplasOperadorDescontrucaoObjeto.models
{
    public class Tuplas
    {
        public void TuplaBasica()
        {
            (int, string, string, decimal) dados = (1, "Lucas", "Silva", 67.05M);
            Console.WriteLine($"Id: {dados.Item1}");
            Console.WriteLine($"Nome: {dados.Item2}");
            Console.WriteLine($"Sobrenome: {dados.Item3}");
            Console.WriteLine($"Peso: {dados.Item4}");
        }

        public void ExemploTupla2()
        {
            (int Id, string Nome, string Sobrenome, decimal Peso) dados = (2, "Carol", "Souza", 59.05M);

            Console.WriteLine($"Id: {dados.Id}");
            Console.WriteLine($"Nome: {dados.Nome}");
            Console.WriteLine($"Sobrenome: {dados.Sobrenome}");
            Console.WriteLine($"Peso: {dados.Peso}");

        }
        public void ExemploTupla3()
        {
            ValueTuple<int, string, string, decimal> dados = (3, "João", "Lucas", 70.05M);

            Console.WriteLine($"Id: {dados.Item1}");
            Console.WriteLine($"Nome: {dados.Item2}");
            Console.WriteLine($"Sobrenome: {dados.Item3}");
            Console.WriteLine($"Peso: {dados.Item4}");
        }
        public void ExemploTupla4()
        {
            var dados = Tuple.Create(4, "Camila", "Gomes", 55.34M);
            
            Console.WriteLine($"Id: {dados.Item1}");
            Console.WriteLine($"Nome: {dados.Item2}");
            Console.WriteLine($"Sobrenome: {dados.Item3}");
            Console.WriteLine($"Peso: {dados.Item4}");

        }
    }
}
