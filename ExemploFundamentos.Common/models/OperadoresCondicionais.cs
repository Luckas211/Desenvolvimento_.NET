using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.models
{
    public class OperadoresCondicionais
    {
        /// <summary>
        /// Introdução aos operadores condicionais.
        /// Operadores condicionais permitem executar diferentes blocos de código baseado em condições.
        /// Os principais são: if, else if, else, switch, operador ternário (? :).
        /// Estruturas condicionais: if (se), else if (senão se), else (senão).
        /// </summary>
        public void IntroducaoOperadoresCondicionais()
        {
            Console.WriteLine("--- Introdução aos Operadores Condicionais ---");
            Console.WriteLine("Operadores condicionais permitem executar diferentes ações baseado em condições booleanas.");
            Console.WriteLine("Principais estruturas:");
            Console.WriteLine("- if: Executa um bloco se a condição for verdadeira.");
            Console.WriteLine("- else if: Executa se a condição anterior for falsa e esta for verdadeira.");
            Console.WriteLine("- else: Executa se nenhuma condição anterior for verdadeira.");
            Console.WriteLine("- switch: Permite múltiplas seleções baseado no valor de uma expressão.");
            Console.WriteLine("- Operador ternário (? :): Forma compacta de if/else.");
            Console.WriteLine();

            // Demonstração básica
            Console.WriteLine("Digite sua idade:");
            string? input = Console.ReadLine();
            int idade;

            if (int.TryParse(input, out idade))
            {
                if (idade < 18)
                {
                    Console.WriteLine("Você é menor de idade.");
                }
                else if (idade >= 18 && idade < 65)
                {
                    Console.WriteLine("Você é adulto.");
                }
                else
                {
                    Console.WriteLine("Você é idoso.");
                }
            }
            else
            {
                Console.WriteLine("Idade inválida. Digite um número.");
            }
        }

        /// <summary>
        /// Operador condicional na prática com debugging.
        /// Demonstra o uso prático do operador condicional (if/else) com entrada do usuário.
        /// Inclui debugging mostrando os valores das variáveis em cada passo.
        /// </summary>
        public void OperadorCondicionalNaPratica()
        {
            Console.WriteLine("--- Operador Condicional na Prática (com Debugging) ---");
            Console.WriteLine("Vamos verificar se você pode dirigir baseado na sua idade e se tem carteira.");
            Console.WriteLine();

            Console.WriteLine("Digite sua idade:");
            string? idadeInput = Console.ReadLine();
            Console.WriteLine("Você tem carteira de motorista? (s/n):");
            string? carteiraInput = Console.ReadLine();

            int idade;
            bool temCarteira = false;

            // Parsing e validação
            bool idadeValida = int.TryParse(idadeInput, out idade);
            if (!idadeValida)
            {
                Console.WriteLine("ERRO: Idade inválida! Digite um número.");
                return;
            }

            if (carteiraInput?.ToLower() == "s")
            {
                temCarteira = true;
            }
            else if (carteiraInput?.ToLower() == "n")
            {
                temCarteira = false;
            }
            else
            {
                Console.WriteLine("ERRO: Resposta inválida para carteira! Digite 's' ou 'n'.");
                return;
            }

            // Debugging - mostrando valores
            Console.WriteLine("=== DEBUGGING DOS VALORES ===");
            Console.WriteLine($"Idade digitada: {idadeInput}");
            Console.WriteLine($"Idade convertida: {idade}");
            Console.WriteLine($"Carteira input: {carteiraInput}");
            Console.WriteLine($"Tem carteira: {temCarteira}");
            Console.WriteLine("==============================");

            // Lógica condicional
            if (idade >= 18 && temCarteira)
            {
                Console.WriteLine("✅ Você pode dirigir! Tem idade suficiente e carteira.");
            }
            else if (idade >= 18 && !temCarteira)
            {
                Console.WriteLine("⚠️ Você tem idade para dirigir, mas precisa tirar carteira primeiro.");
            }
            else if (idade < 18 && temCarteira)
            {
                Console.WriteLine("❌ Você não tem idade suficiente, mesmo tendo carteira.");
            }
            else
            {
                Console.WriteLine("❌ Você não pode dirigir. Menor de idade e sem carteira.");
            }
        }

        /// <summary>
        /// If alinhado (nested if).
        /// Demonstra o uso de estruturas if aninhadas para verificações múltiplas.
        /// </summary>
        public void IfAlinhado()
        {
            Console.WriteLine("--- If Alinhado (Nested If) ---");
            Console.WriteLine("Vamos classificar um estudante baseado em notas e frequência.");
            Console.WriteLine();

            Console.WriteLine("Digite a nota do aluno (0-10):");
            string? notaInput = Console.ReadLine();
            Console.WriteLine("Digite a frequência do aluno (0-100%):");
            string? frequenciaInput = Console.ReadLine();

            double nota;
            double frequencia;

            // Validação
            if (!double.TryParse(notaInput, out nota) || nota < 0 || nota > 10)
            {
                Console.WriteLine("ERRO: Nota inválida! Digite um valor entre 0 e 10.");
                return;
            }

            if (!double.TryParse(frequenciaInput, out frequencia) || frequencia < 0 || frequencia > 100)
            {
                Console.WriteLine("ERRO: Frequência inválida! Digite um valor entre 0 e 100.");
                return;
            }

            Console.WriteLine("=== AVALIAÇÃO DO ALUNO ===");
            Console.WriteLine($"Nota: {nota}");
            Console.WriteLine($"Frequência: {frequencia}%");

            // If alinhado para classificação
            if (frequencia >= 75)
            {
                Console.WriteLine("✅ Frequência suficiente!");

                if (nota >= 9.0)
                {
                    Console.WriteLine("🏆 Excelente! Aprovado com distinção.");
                }
                else if (nota >= 7.0)
                {
                    Console.WriteLine("✅ Aprovado! Bom desempenho.");
                }
                else if (nota >= 5.0)
                {
                    Console.WriteLine("⚠️ Aprovado! Precisa melhorar.");
                }
                else
                {
                    Console.WriteLine("❌ Reprovado por nota insuficiente.");
                }
            }
            else
            {
                Console.WriteLine("❌ Frequência insuficiente! Reprovado independentemente da nota.");

                // If alinhado dentro do else
                if (nota >= 7.0)
                {
                    Console.WriteLine("💡 Nota boa, mas frequência baixa. Considere recuperação.");
                }
                else
                {
                    Console.WriteLine("📉 Nota e frequência baixas. Muito estudo necessário.");
                }
            }
        }

        /// <summary>
        /// Aprendendo Switch Case.
        /// Demonstra o uso da estrutura switch-case para múltiplas seleções.
        /// </summary>
        public void AprendendoSwitchCase()
        {
            Console.WriteLine("--- Aprendendo Switch Case ---");
            Console.WriteLine("Switch-case é usado quando temos múltiplas opções baseado no valor de uma variável.");
            Console.WriteLine("Vamos ver um exemplo com dias da semana.");
            Console.WriteLine();

            Console.WriteLine("Digite um número de 1 a 7 para o dia da semana:");
            string? diaInput = Console.ReadLine();

            int dia;
            if (!int.TryParse(diaInput, out dia) || dia < 1 || dia > 7)
            {
                Console.WriteLine("ERRO: Dia inválido! Digite um número de 1 a 7.");
                return;
            }

            // Switch case para dias da semana
            string nomeDia;
            string tipoDia;

            switch (dia)
            {
                case 1:
                    nomeDia = "Domingo";
                    tipoDia = "Final de semana";
                    break;
                case 2:
                    nomeDia = "Segunda-feira";
                    tipoDia = "Dia útil";
                    break;
                case 3:
                    nomeDia = "Terça-feira";
                    tipoDia = "Dia útil";
                    break;
                case 4:
                    nomeDia = "Quarta-feira";
                    tipoDia = "Dia útil";
                    break;
                case 5:
                    nomeDia = "Quinta-feira";
                    tipoDia = "Dia útil";
                    break;
                case 6:
                    nomeDia = "Sexta-feira";
                    tipoDia = "Dia útil";
                    break;
                case 7:
                    nomeDia = "Sábado";
                    tipoDia = "Final de semana";
                    break;
                default:
                    nomeDia = "Desconhecido";
                    tipoDia = "Desconhecido";
                    break;
            }

            Console.WriteLine($"Dia {dia}: {nomeDia}");
            Console.WriteLine($"Tipo: {tipoDia}");

            // Outro exemplo: switch com string
            Console.WriteLine();
            Console.WriteLine("Agora digite o nome de uma fruta (maçã, banana, laranja):");
            string? fruta = Console.ReadLine()?.ToLower();

            string corFruta = fruta switch
            {
                "maçã" => "Vermelha ou Verde",
                "banana" => "Amarela",
                "laranja" => "Laranja",
                _ => "Cor desconhecida"
            };

            Console.WriteLine($"A {fruta} geralmente é {corFruta}.");

            // Exemplo com múltiplos cases
            Console.WriteLine();
            Console.WriteLine("Digite um mês (1-12) para ver a estação:");
            string? mesInput = Console.ReadLine();

            if (int.TryParse(mesInput, out int mes) && mes >= 1 && mes <= 12)
            {
                string estacao = mes switch
                {
                    12 or 1 or 2 => "Verão",
                    3 or 4 or 5 => "Outono",
                    6 or 7 or 8 => "Inverno",
                    9 or 10 or 11 => "Primavera",
                    _ => "Desconhecido"
                };

                Console.WriteLine($"Mês {mes} é {estacao} no Brasil.");
            }
            else
            {
                Console.WriteLine("Mês inválido!");
            }
        }
    }
}
