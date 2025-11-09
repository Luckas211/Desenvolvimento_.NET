using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoEncapsulamento.models
{
    public class Diretor : Professor
    {
        // Construtor padrão para Diretor, chamando o construtor base de Professor com um nome padrão ou parâmetro.
        // Como Professor requer um parâmetro 'nome' no construtor, devemos fornecer um ou definir um construtor próprio.
        // Aqui, definimos um construtor que aceita nome e passa para base.
        public Diretor(string nome) : base(nome)
        {
        }

        public override void Apresentar5()
        {
            Console.WriteLine("Diretor");
        }
    }
}