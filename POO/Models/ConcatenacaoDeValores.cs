using System;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar concatenação de valores em C#.
    /// Mostra como combinar números e textos em strings.
    /// Exemplo: criar etiquetas de produtos com código e preço.
    /// </summary>
    public class ConcatenacaoDeValores
    {
        /// <summary>
        /// Método que executa o exemplo de concatenação de valores.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 5. Concatenação de Valores ===");

            // Declarando valores: int e double
            int codigoProduto = 123;
            double preco = 45.99;
            string nomeProduto = "Camiseta";

            // Concatenando valores: juntando número e texto
            string etiqueta1 = "Produto: " + nomeProduto + ", Código: " + codigoProduto + ", Preço: R$ " + preco;

            // Usando interpolação para concatenação mais limpa
            string etiqueta2 = $"Produto: {nomeProduto}, Código: {codigoProduto}, Preço: R$ {preco}";

            Console.WriteLine(etiqueta1);
            Console.WriteLine(etiqueta2);

            // Exemplo com cálculo: preço com desconto
            double desconto = 5.00;
            double precoComDesconto = preco - desconto;
            string etiquetaDesconto = $"Produto: {nomeProduto}, Preço original: R$ {preco}, Com desconto: R$ {precoComDesconto}";
            Console.WriteLine(etiquetaDesconto);
            Console.WriteLine();
        }
    }
}
