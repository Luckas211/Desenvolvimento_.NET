using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.models

{
    public class Operadores
    {
        public int numero1 { get; set; }
        public int numero2 { get; set; }
        public int resultado { get; set; }

        public void somar()
        {
            resultado = numero1 + numero2;
            Console.WriteLine($"O resultado da soma é: {resultado}");


        }
        public void subtrair()
        {
            resultado = numero1 - numero2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");

        }
        public void multiplicar()
        {
            resultado = numero1 * numero2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");

        }
        public void dividir()
        {
            // double resultado = Convert.ToDouble(numero1) / Convert.ToDouble(numero2);
            // Console.WriteLine($"O resultado da divisão é: {resultado}");

            // double resultado = Double.Parse(numero1.ToString()) / Double.Parse(numero2.ToString());
            // Console.WriteLine($"O resultado da divisão é: {resultado}");

            double divisor1 = numero1;
            double divisor2 = numero2;
            double resultado = divisor1 / divisor2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");




        }

        /// <summary>
        /// Introdução ao operador de atribuição (=).
        /// O operador de atribuição atribui o valor à direita à variável à esquerda.
        /// </summary>
        public void IntroducaoAtribuicao()
        {
            Console.WriteLine("--- Introdução ao Operador de Atribuição (=) ---");
            int x = 10; // Atribuição simples
            Console.WriteLine($"x = {x}");

            string nome = "Lucas"; // Atribuição de string
            Console.WriteLine($"nome = {nome}");

            bool ativo = true; // Atribuição de booleano
            Console.WriteLine($"ativo = {ativo}");
        }

        /// <summary>
        /// Combinando operadores (operadores compostos).
        /// Exemplos: +=, -=, *=, /=, %=
        /// </summary>
        public void CombinandoOperadores()
        {
            Console.WriteLine("--- Combinando Operadores ---");
            int a = 5;
            Console.WriteLine($"a inicial: {a}");

            a += 3; // a = a + 3
            Console.WriteLine($"a += 3: {a}");

            a -= 2; // a = a - 2
            Console.WriteLine($"a -= 2: {a}");

            a *= 4; // a = a * 4
            Console.WriteLine($"a *= 4: {a}");

            a /= 2; // a = a / 2
            Console.WriteLine($"a /= 2: {a}");

            a %= 3; // a = a % 3
            Console.WriteLine($"a %= 3: {a}");
        }

        /// <summary>
        /// Convertendo tipos de variáveis.
        /// Exemplos de conversão explícita e implícita.
        /// </summary>
        public void ConvertendoTipos()
        {
            Console.WriteLine("--- Convertendo Tipos de Variáveis ---");

            // Conversão implícita (int para double)
            int inteiro = 10;
            double real = inteiro; // Implícita
            Console.WriteLine($"int para double: {real}");

            // Conversão explícita (double para int)
            double valor = 15.7;
            int convertido = (int)valor; // Explícita com cast
            Console.WriteLine($"double para int (cast): {convertido}");

            // Usando Convert.ToInt32
            string texto = "123";
            int numero = Convert.ToInt32(texto);
            Console.WriteLine($"string para int (Convert): {numero}");
        }

        /// <summary>
        /// Diferença entre Convert e Parse.
        /// Convert.ToInt32() pode lidar com null e tipos diferentes, Parse() só com strings.
        /// </summary>
        public void DiferencaConvertParse()
        {
            Console.WriteLine("--- Diferença entre Convert e Parse ---");

            string numeroStr = "456";

            // Usando Parse (só para strings)
            int parseado = int.Parse(numeroStr);
            Console.WriteLine($"int.Parse(\"456\"): {parseado}");

            // Usando Convert (mais flexível, lida com null)
            object obj = 789;
            int convertido = Convert.ToInt32(obj);
            Console.WriteLine($"Convert.ToInt32(789): {convertido}");

            // Convert com null
            object nulo = null;
            try
            {
                int convNull = Convert.ToInt32(nulo); // Retorna 0
                Console.WriteLine($"Convert.ToInt32(null): {convNull}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro com Convert.ToInt32(null): {ex.Message}");
            }

            // Parse com null daria erro
            try
            {
                int parseNull = int.Parse((string)nulo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro com int.Parse(null): {ex.Message}");
            }
        }

        /// <summary>
        /// Conversão para string.
        /// Usando ToString(), interpolação e Convert.ToString().
        /// </summary>
        public void ConversaoParaString()
        {
            Console.WriteLine("--- Conversão para String ---");

            int numero = 42;
            double pi = 3.14159;

            // ToString()
            string str1 = numero.ToString();
            Console.WriteLine($"numero.ToString(): {str1}");

            // Interpolação
            string str2 = $"{numero} e {pi}";
            Console.WriteLine($"Interpolação: {str2}");

            // Convert.ToString()
            string str3 = Convert.ToString(pi);
            Console.WriteLine($"Convert.ToString(pi): {str3}");
        }

        /// <summary>
        /// Cast implícito.
        /// Conversões automáticas onde não há perda de dados.
        /// </summary>
        public void CastImplicito()
        {
            Console.WriteLine("--- Cast Implícito ---");

            // int para long (sem perda)
            int pequeno = 100;
            long grande = pequeno; // Implícito
            Console.WriteLine($"int para long: {grande}");

            // float para double
            float flutuante = 1.5f;
            double duplo = flutuante; // Implícito
            Console.WriteLine($"float para double: {duplo}");

            // char para int (código ASCII)
            char letra = 'A';
            int codigo = letra; // Implícito
            Console.WriteLine($"char 'A' para int: {codigo}");
        }

        /// <summary>
        /// Ordem dos operadores (precedência).
        /// Exemplos mostrando como a ordem afeta o resultado.
        /// </summary>
        public void OrdemOperadores()
        {
            Console.WriteLine("--- Ordem dos Operadores ---");

            int a = 2, b = 3, c = 4;

            // Sem parênteses: multiplicação tem precedência
            int resultado1 = a + b * c; // 2 + 12 = 14
            Console.WriteLine($"a + b * c = {resultado1}");

            // Com parênteses: soma primeiro
            int resultado2 = (a + b) * c; // 5 * 4 = 20
            Console.WriteLine($"(a + b) * c = {resultado2}");

            // Ordem: * / % têm precedência sobre + -
            int resultado3 = a * b + c / 2; // 6 + 2 = 8
            Console.WriteLine($"a * b + c / 2 = {resultado3}");
        }

        /// <summary>
        /// Convertendo de maneira segura.
        /// Usando TryParse para evitar exceções.
        /// </summary>
        public void ConversaoSegura()
        {
            Console.WriteLine("--- Convertendo de Maneira Segura ---");

            string[] entradas = { "123", "abc", "45.67", null };

            foreach (string entrada in entradas)
            {
                if (int.TryParse(entrada, out int numero))
                {
                    Console.WriteLine($"\"{entrada}\" convertido para int: {numero}");
                }
                else
                {
                    Console.WriteLine($"\"{entrada}\" não pôde ser convertido para int");
                }
            }

            // Para double
            string valor = "3.14";
            if (double.TryParse(valor, out double d))
            {
                Console.WriteLine($"\"{valor}\" convertido para double: {d}");
            }
        }
    }
}
