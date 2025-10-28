using System;
using System.Collections.Generic;

namespace POO.Models
{
    public class Lista
    {
        public List<string> Elementos = new List<string>();

        public void AdicionarElementos()
        {
            Elementos.Add("Elemento 1");
            Elementos.Add("Elemento 2");
            Elementos.Add("Elemento 3");
        }

        public void ListarElementos()
        {
            Console.WriteLine("Elementos da lista:");
            for (int i = 0; i < Elementos.Count; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {Elementos[i]}");
            }
        }
    }
}
