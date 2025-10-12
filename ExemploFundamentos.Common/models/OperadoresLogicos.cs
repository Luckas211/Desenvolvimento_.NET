using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.models
{
    public class OperadoresLogicos
    {
        public int QuantidadeEmEstoque { get; set; }
        public int QuantidadeCompra { get; set; }

        public void VerificarVenda()
        {
            bool PossivelVenda = QuantidadeEmEstoque >= QuantidadeCompra;

            if (PossivelVenda)
            {
                Console.WriteLine("Venda realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque para a venda.");
            }

        }

        /// <summary>
        /// Introdução aos operadores lógicos e estruturas condicionais if/else/else if.
        /// Operadores lógicos são usados para combinar ou inverter condições booleanas.
        /// Os principais operadores são: && (AND), || (OR), ! (NOT).
        /// Estruturas condicionais: if (se), else if (senão se), else (senão).
        /// </summary>
        public void IntroducaoOperadoresLogicos()
        {
            Console.WriteLine("--- Introdução aos Operadores Lógicos e Estruturas Condicionais ---");
            Console.WriteLine("Operadores lógicos combinam ou invertem valores booleanos (verdadeiro/falso).");
            Console.WriteLine("Principais operadores:");
            Console.WriteLine("- && (AND): Verdadeiro se ambas as condições forem verdadeiras.");
            Console.WriteLine("- || (OR): Verdadeiro se pelo menos uma condição for verdadeira.");
            Console.WriteLine("- ! (NOT): Inverte o valor booleano.");
            Console.WriteLine("Estruturas condicionais:");
            Console.WriteLine("- if: Executa se a condição for verdadeira.");
            Console.WriteLine("- else if: Executa se a condição anterior for falsa e esta for verdadeira.");
            Console.WriteLine("- else: Executa se nenhuma condição anterior for verdadeira.");
            Console.WriteLine("Exemplo básico:");
            bool a = true;
            bool b = false;
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"a && b = {a && b} (AND)");
            Console.WriteLine($"a || b = {a || b} (OR)");
            Console.WriteLine($"!a = {!a} (NOT)");
            Console.WriteLine("Usando if/else if/else:");
            if (a && b)
            {
                Console.WriteLine("Ambas as condições são verdadeiras (AND).");
            }
            else if (a || b)
            {
                Console.WriteLine("Pelo menos uma condição é verdadeira (OR).");
            }
            else
            {
                Console.WriteLine("Nenhuma condição é verdadeira.");
            }
            if (!a)
            {
                Console.WriteLine("A condição invertida é verdadeira (NOT).");
            }
            else if (!b)
            {
                Console.WriteLine("A segunda condição invertida é verdadeira (NOT).");
            }
            else
            {
                Console.WriteLine("Nenhuma condição invertida é verdadeira (NOT).");
            }

            // Teste de edge case: ambas falsas
            bool c = false;
            bool d = false;
            Console.WriteLine("Teste edge case - ambas falsas:");
            if (c && d)
            {
                Console.WriteLine("Ambas verdadeiras (não deve aparecer).");
            }
            else if (c || d)
            {
                Console.WriteLine("Pelo menos uma verdadeira (não deve aparecer).");
            }
            else
            {
                Console.WriteLine("Nenhuma condição é verdadeira (edge case).");
            }
        }

        /// <summary>
        /// Operador OR (||) na prática.
        /// O operador OR retorna verdadeiro se pelo menos uma das condições for verdadeira.
        /// Usando if/else if/else para demonstrar múltiplas possibilidades.
        /// </summary>
        public void OperadorORNaPratica()
        {
            Console.WriteLine("--- Operador OR (||) na Prática ---");
            Console.WriteLine("Exemplo: Verificar se um produto está em promoção OU se o cliente tem desconto.");

            bool emPromocao = false;
            bool clienteTemDesconto = true;

            if (emPromocao && clienteTemDesconto)
            {
                Console.WriteLine("Desconto máximo aplicado! Ambas as condições são verdadeiras.");
            }
            else if (emPromocao || clienteTemDesconto)
            {
                Console.WriteLine("Desconto aplicado! Pelo menos uma condição é verdadeira (OR).");
            }
            else
            {
                Console.WriteLine("Nenhum desconto aplicado. Nenhuma condição é verdadeira (OR).");
            }

            Console.WriteLine($"Produto em promoção: {emPromocao}");
            Console.WriteLine($"Cliente tem desconto: {clienteTemDesconto}");

            // Outro exemplo
            int idade = 25;
            bool maiorDeIdade = idade >= 18;
            bool temPermissao = false;

            if (maiorDeIdade && temPermissao)
            {
                Console.WriteLine("Entrada VIP permitida! Ambas as condições são verdadeiras.");
            }
            else if (maiorDeIdade || temPermissao)
            {
                Console.WriteLine("Entrada permitida! Pelo menos uma condição é verdadeira (OR).");
            }
            else
            {
                Console.WriteLine("Entrada negada. Nenhuma condição é verdadeira (OR).");
            }

            Console.WriteLine($"Idade: {idade}, Maior de idade: {maiorDeIdade}, Tem permissão: {temPermissao}");
        }

        /// <summary>
        /// Introdução ao operador AND (&&).
        /// O operador AND retorna verdadeiro apenas se ambas as condições forem verdadeiras.
        /// Usando if/else if/else para demonstrar múltiplas combinações.
        /// </summary>
        public void IntroducaoOperadorAND()
        {
            Console.WriteLine("--- Introdução ao Operador AND (&&) ---");
            Console.WriteLine("O operador AND (&&) retorna verdadeiro apenas se TODAS as condições forem verdadeiras.");
            Console.WriteLine("Exemplo básico:");

            bool condicao1 = true;
            bool condicao2 = true;
            bool condicao3 = false;

            Console.WriteLine($"Condição 1: {condicao1}, Condição 2: {condicao2}, Condição 3: {condicao3}");

            if (condicao1 && condicao2 && condicao3)
            {
                Console.WriteLine("Todas as três condições são verdadeiras (AND).");
            }
            else if (condicao1 && condicao2)
            {
                Console.WriteLine("Duas condições são verdadeiras (AND).");
            }
            else if (condicao1 && condicao3)
            {
                Console.WriteLine("Condições 1 e 3 são verdadeiras (AND).");
            }
            else if (condicao2 && condicao3)
            {
                Console.WriteLine("Condições 2 e 3 são verdadeiras (AND).");
            }
            else
            {
                Console.WriteLine("Menos de duas condições são verdadeiras (AND).");
            }

            // Exemplo prático
            int temperatura = 25;
            bool diaEnsolarado = true;

            if (temperatura > 30 && diaEnsolarado)
            {
                Console.WriteLine("Tempo muito quente e ensolarado! Todas as condições são verdadeiras (AND).");
            }
            else if (temperatura > 20 && diaEnsolarado)
            {
                Console.WriteLine("Bom tempo! Todas as condições são verdadeiras (AND).");
            }
            else if (temperatura > 20 || diaEnsolarado)
            {
                Console.WriteLine("Tempo razoável. Pelo menos uma condição é verdadeira.");
            }
            else
            {
                Console.WriteLine("Tempo ruim. Nem todas as condições são verdadeiras (AND).");
            }

            Console.WriteLine($"Temperatura: {temperatura}°C, Dia ensolarado: {diaEnsolarado}");
        }

        /// <summary>
        /// Introdução ao operador NOT (!).
        /// O operador NOT inverte o valor booleano: verdadeiro vira falso e vice-versa.
        /// Usando if/else para demonstrar a lógica.
        /// </summary>
        public void IntroducaoOperadorNOT()
        {
            Console.WriteLine("--- Introdução ao Operador NOT (!) ---");
            Console.WriteLine("O operador NOT (!) inverte o valor de uma expressão booleana.");
            Console.WriteLine("Se a condição for verdadeira, !condicao será falsa, e vice-versa.");

            bool verdadeiro = true;
            bool falso = false;

            Console.WriteLine($"verdadeiro = {verdadeiro}, !verdadeiro = {!verdadeiro}");
            Console.WriteLine($"falso = {falso}, !falso = {!falso}");

            // Exemplo prático
            bool estaChovendo = false;

            if (!estaChovendo)
            {
                Console.WriteLine("Não está chovendo! A condição invertida é verdadeira (NOT).");
            }
            else
            {
                Console.WriteLine("Está chovendo. A condição invertida é falsa (NOT).");
            }

            Console.WriteLine($"Está chovendo: {estaChovendo}");
        }

        /// <summary>
        /// Operador NOT (!) na prática.
        /// Exemplo prático de uso do operador NOT para inverter condições.
        /// Usando if/else para demonstrar a lógica.
        /// </summary>
        public void OperadorNOTNaPratica()
        {
            Console.WriteLine("--- Operador NOT (!) na Prática ---");
            Console.WriteLine("Exemplo: Verificar se um usuário NÃO está logado para redirecionar ao login.");

            bool usuarioLogado = false;

            if (!usuarioLogado)
            {
                Console.WriteLine("Redirecionar para login! Usuário não está logado (NOT).");
            }
            else
            {
                Console.WriteLine("Usuário já está logado. Não precisa redirecionar (NOT).");
            }

            Console.WriteLine($"Usuário logado: {usuarioLogado}");

            // Outro exemplo: Verificar se não é fim de semana
            string diaDaSemana = "domingo";
            bool ehFimDeSemana = diaDaSemana == "sabado" || diaDaSemana == "domingo";

            if (!ehFimDeSemana)
            {
                Console.WriteLine("É um dia útil! Não é fim de semana (NOT).");
            }
            else
            {
                Console.WriteLine("É fim de semana. Não é dia útil (NOT).");
            }

            Console.WriteLine($"Dia da semana: {diaDaSemana}");
            Console.WriteLine($"É fim de semana: {ehFimDeSemana}");
        }
    }
}
