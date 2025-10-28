using System;

namespace TuplasOperadorDescontrucaoObjeto.models
{
    public class IfTenario
    {
        public void ExemploBasico()
        {
            Console.WriteLine("=== Exemplo 1: If ternário básico ===");

            int numero = 10;

            // O operador ternário funciona assim:
            // (condição) ? valor_se_verdadeiro : valor_se_falso
            string resultado = (numero > 5) ? "Maior que 5" : "Menor ou igual a 5";

            Console.WriteLine($"O número {numero} é: {resultado}");
        }

        public void ExemploComEntradaDoUsuario()
        {
            Console.WriteLine("\n=== Exemplo 2: If ternário com entrada do usuário ===");

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            // Se a idade for 18 ou mais → "Maior de idade"
            // Caso contrário → "Menor de idade"
            string status = (idade >= 18) ? "Maior de idade" : "Menor de idade";

            Console.WriteLine($"Você é: {status}");
        }

        public void ExemploAninhado()
        {
            Console.WriteLine("\n=== Exemplo 3: If ternário aninhado (vários níveis) ===");

            int nota = 85;

            // Você pode aninhar operadores ternários, mas com cuidado!
            string classificacao = (nota >= 90) ? "Excelente"
                                : (nota >= 70) ? "Bom"
                                : (nota >= 50) ? "Regular"
                                : "Insuficiente";

            Console.WriteLine($"Sua nota: {nota} → Classificação: {classificacao}");
        }
    }
}
