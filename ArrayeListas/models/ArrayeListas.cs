using System;
using System.Collections.Generic;

namespace ArrayeListas.models
{
    public class ArrayeListas_Exemplos
    {
        public void DemonstrarArray()
        {
            Console.WriteLine("Demonstrando Arrays:");
            // Declarando e inicializando um array de inteiros
            int[] numeros = new int[5] { 1, 2, 3, 4, 5 };

            // Acessando elementos
            Console.WriteLine($"Primeiro elemento: {numeros[0]}");
            Console.WriteLine($"Último elemento: {numeros[4]}");

            // Iterando com for
            Console.Write("Iterando com for: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]} ");
            }
            Console.WriteLine();

            // Iterando com foreach
            Console.Write("Iterando com foreach: ");
            foreach (int num in numeros)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

        public void DemonstrarLista()
        {
            Console.WriteLine("Demonstrando Listas:");
            // Declarando e inicializando uma lista de strings
            List<string> frutas = new List<string> { "Maçã", "Banana", "Laranja" };

            // Adicionando elementos
            frutas.Add("Uva");
            frutas.Add("Pêra");

            Console.WriteLine("Lista após adicionar: " + string.Join(", ", frutas));

            // Removendo elemento
            frutas.Remove("Banana");
            Console.WriteLine("Lista após remover Banana: " + string.Join(", ", frutas));

            // Acessando por índice
            Console.WriteLine($"Elemento na posição 1: {frutas[1]}");

            // Iterando com foreach
            Console.Write("Iterando com foreach: ");
            foreach (string fruta in frutas)
            {
                Console.Write($"{fruta} ");
            }
            Console.WriteLine();

            // Ordenando
            frutas.Sort();
            Console.WriteLine("Lista ordenada: " + string.Join(", ", frutas));

            // Contando elementos
            Console.WriteLine($"Número de elementos: {frutas.Count}");
        }

        public void DemonstrarArrayMultidimensional()
        {
            Console.WriteLine("Demonstrando Array Multidimensional:");
            // Array 2D
            int[,] matriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void DemonstrarListaGenerica()
        {
            Console.WriteLine("Demonstrando Lista Genérica com Objetos:");
            List<PessoaSimples> pessoas = new List<PessoaSimples>
            {
                new PessoaSimples { Nome = "João", Idade = 25 },
                new PessoaSimples { Nome = "Maria", Idade = 30 }
            };

            pessoas.Add(new PessoaSimples { Nome = "Pedro", Idade = 35 });

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade} anos");
            }
        }
        public void Array_inteiros()
        {
            int[] ArrayInteiros = new int[3];
            ArrayInteiros[0] = 27;
            ArrayInteiros[1] = 28;
            ArrayInteiros[2] = 29;
            Console.WriteLine("Percorrendo o Aray com o FOR");
            for (int contador = 0; contador < ArrayInteiros.Length; contador++)
            {
                Console.WriteLine($"Posição Nº{contador} = {ArrayInteiros[contador]}");
            }
            int contadorForeach = 0;
            Console.WriteLine("Percorrendo o Aray com o FOREACH");
            foreach (int valor in ArrayInteiros)
            {
                Console.WriteLine($"A posição Nº{contadorForeach} = {valor}");
                contadorForeach++;
            }
            Console.WriteLine("\nMétodos de redimensionamento do Array");
            Array.Resize(ref ArrayInteiros, ArrayInteiros.Length * 2);
            ArrayInteiros[3] = 30;
            ArrayInteiros[4] = 31;

            foreach (int valor2 in ArrayInteiros)
            {
                Console.WriteLine($"{valor2}");
            }
        }

        public void Copiar_Array()
        {
            int[] original = new int[3];
            original[0] = 10;
            original[1] = 20;
            original[2] = 30;


            foreach (int valor in original)
            {
                Console.WriteLine($"Essa é a Array original: {valor}");

            }
            Console.WriteLine("");
            int[] ArrayCopiado = new int[original.Length * 2];
            Array.Copy(original, ArrayCopiado, original.Length);
            ArrayCopiado[3] = 40;
            foreach (int valor2 in ArrayCopiado)
            {
                Console.WriteLine($"Essa é a Array Copiada: {valor2}");
            }

        }
        public void Listas()
        {
            List<string> ListaString = new List<string>();
            ListaString.Add("Rio de Janeiro");
            ListaString.Add("São Paulo");
            ListaString.Add("Minas Gerais");
            ListaString.Add("Acre");

            Console.WriteLine($"Itens na minha lista: {ListaString.Count} - Capacidade: {ListaString.Capacity}");
            ListaString.Add("Rio Grande do Sul");
            Console.WriteLine($"Itens na minha lista: {ListaString.Count} - Capacidade: {ListaString.Capacity}");
            ListaString.Remove("Rio Grande do Sul");
            Console.WriteLine($"Itens na minha lista: {ListaString.Count} - Capacidade: {ListaString.Capacity}");

            Console.WriteLine("");
            Console.WriteLine("Percorrendo a Lista com FOREACH");
            foreach (string str in ListaString)
            {
                Console.WriteLine($"Dentro de nossa lista temos as seguintes regiões {str}");

            }
            Console.WriteLine("");
            Console.WriteLine("Percorrendo a Lista com FOR");
            for (int contador = 0; contador < ListaString.Count; contador++)
            {
                Console.WriteLine($"Posição Nº {contador} - {ListaString[contador]}");
            }

        }
            
                  }

    

    // Classe simples para demonstração
    public class PessoaSimples
    {
        public string? Nome { get; set; }
        public int? Idade { get; set; }
    }
    

}
