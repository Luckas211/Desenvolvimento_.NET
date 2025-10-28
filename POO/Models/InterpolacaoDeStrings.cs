using System;

namespace POO.Models
{
    /// <summary>
    /// Classe para demonstrar interpolação de strings em C#.
    /// Mostra como inserir valores diretamente em textos usando $"".
    /// Exemplo: criar um relatório simples de vendas.
    /// </summary>
    public class InterpolacaoDeStrings
    {
        /// <summary>
        /// Método que executa o exemplo de interpolação de strings.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("=== 3. Interpolação de Strings ===");

            // Declarando variáveis para o exemplo
            string produto = "celular";
            double preco = 1500.00;
            int quantidadeVendida = 10;

            // Interpolação: usa $ antes das aspas e {} para inserir valores
            string relatorio = $"Produto: {produto}, Preço: R$ {preco}, Vendidos: {quantidadeVendida}";

            // Exibindo o relatório
            Console.WriteLine(relatorio);

            // Exemplo com cálculo dentro da interpolação
            double totalVendas = preco * quantidadeVendida;
            string relatorioCompleto = $"Relatório: {quantidadeVendida} {produto}(s) vendidos, totalizando R$ {totalVendas}";
            Console.WriteLine(relatorioCompleto);

            // Comparação com concatenação (menos legível)
            string relatorioConcat = "Relatório: " + quantidadeVendida + " " + produto + "(s) vendidos, totalizando R$ " + totalVendas;
            Console.WriteLine("Concatenação: " + relatorioConcat);
            Console.WriteLine();
        }
    }
}
