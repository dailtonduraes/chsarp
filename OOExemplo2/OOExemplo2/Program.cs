using System;
using System.Globalization;

namespace OOExemplo2 {
    class Program {
        static void Main(string[] args) {
            Produto prod;
            prod = new Produto();
            Console.WriteLine("Informe os dados do produto");
            Console.Write("Nome: ");
            prod.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            prod.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            prod.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + prod);

            Console.WriteLine("");
            Console.WriteLine("Digite a Quantidade de produtos a ser adicionado no estoque");
            int qte = int.Parse(Console.ReadLine());
            prod.AdicionarProdutos(qte);
            Console.WriteLine("Dados Atualizados " + prod);

            Console.WriteLine("");
            Console.WriteLine("Digite a Quantidade de produtos a ser removido do estoque");
            qte = int.Parse(Console.ReadLine());
            prod.RemoverProdutos(qte);
            Console.WriteLine("Dados Atualizados " + prod);

        }
    }
}
