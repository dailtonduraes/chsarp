using System;
using System.Globalization;

namespace OOExemplo04 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome");
            string nome = Console.ReadLine();
            Console.Write("Preço");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);
            Console.WriteLine();
            Console.WriteLine("Dados do produto " + p);
                
            
        }
    }
}
