using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoEncapsulamento.Interfaces
{
    public interface Icalculadora
    {
        int somar(int numero1, int numero2);
        int subtrair(int numero1, int numero2);
        int multiplicar(int numero1, int numero2);
        int dividir(int numero1, int numero2);
    
    }
}