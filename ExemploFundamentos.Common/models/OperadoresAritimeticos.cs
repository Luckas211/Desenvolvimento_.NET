using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.models

{
    public class OperadoresAritimeticos()


    {
        public void somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void dividir(int x, int y)
        {
            double dividendo = Convert.ToDouble(x);
            double divisor = Convert.ToDouble(y);

            Console.WriteLine($"{dividendo} / {divisor} = {dividendo / divisor}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} graus: {Math.Round(seno, 4)}");
        }
        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo} graus: {Math.Round(cosseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} graus: {tangente}");

        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é: {raiz}");
        }


        public void Incrementando(int x)
        {
            int numero1 = x;
            numero1 = x;
            Console.WriteLine($"O valor original para ser incrementado: {x}");
            numero1++;
            Console.WriteLine($"O valor incrementado {numero1}");

        }
        public void decrementando(int x)
        {
            int numero1 = x;
            numero1 = x;
            Console.WriteLine($"O valor original para ser decrementado: {x}");
            numero1--;
            Console.WriteLine($"O valor decrementado {numero1}");
        }

    }
}
