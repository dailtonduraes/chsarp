using System;
using System.Globalization;


namespace EntradaDados {
    class Program {
        static void Main(string[] args) {
            /*
            //string s = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');

            string item1 = vet[0];
            string item2 = vet[1];
            string item3 = vet[2];

            Console.WriteLine($"{item1}, {item2}, {item3}");*/

            int num1 = int.Parse(Console.ReadLine());
            char genero = char.Parse(Console.ReadLine());
            double numDouble = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou");
            Console.WriteLine(num1);
            Console.WriteLine(genero);
            Console.WriteLine(numDouble);


        }
    }
}
