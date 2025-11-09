using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstracaoEncapsulamento.Interfaces;



namespace AbstracaoEncapsulamento.models
{
    public class Calculadora : Icalculadora
    {
        public int dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        public int multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public int Somar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }

        public int somar(int numero1, int numero2)
        {
            throw new NotImplementedException();
        }

        public int subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }
}