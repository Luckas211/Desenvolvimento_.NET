using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.models
{
    public class EstruturaDeRepeticao
    {

        public void TestandoFor(int numero)
        {

            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }

        }


       public void TestandoWhile(int multiplicador)
{
    int contador = 0; // precisa declarar e iniciar a variável
    int id = 0;

    while (contador <= 10) // a condição do while não usa ';' e nem '='
    {
        Console.WriteLine($"Id {id} {multiplicador} x {contador} = {multiplicador * contador}");
        contador++;
        id++; // incrementa fora do WriteLine para clareza

        if (contador == 6)
        {
            break;
        }
    }
}

    public void TestandoDoWhile()
    {
        int soma = 0;
        int numero = 0;

        do
        {
            Console.WriteLine("Digite um número(0 para parar):");
            numero = Convert.ToInt32(Console.ReadLine());
            soma += numero;
            
        } while(numero != 0);

        Console.WriteLine($"A soma dos números é: {soma}");
    }

    public void MenuInterativo()
    {
        string opcao;
        bool ExibirMenu = true;

        while (ExibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Menu Interativo:");
            Console.WriteLine("1. Cadastrar Cliente");
            Console.WriteLine("2. Buscar Cliente");
            Console.WriteLine("3. Apagar Cliente");
            Console.WriteLine("4. Encerrar");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case"1":
                Console.WriteLine("Cadastro de Cliente");
                break;
                case"2":
                Console.WriteLine("Buscar Cliente");
                break;
                case"3":
                Console.WriteLine("Apagar Cliente");
                break;
                case"4":
                Console.WriteLine("Encerrando o programa...");
                ExibirMenu = false;
                break;
                default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
            }


        }
    }
    }
}