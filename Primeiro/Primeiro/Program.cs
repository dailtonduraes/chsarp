using System;
using System.Globalization;

namespace Primeiro {
    class Program {
        static void Main(string[] args) {

            /*
            sbyte x = 10;
            object obj1 = "Dailton Durães";
            int idade = 36;
            string email = "dailtonduraes@hotmail.com";
            object obj2 = 4.5f;
            char letra = 'M';
            char caracter = '\u0041';
            double numDouble = 12.052525;

            int num1 = int.MinValue;




            Console.WriteLine(x);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(letra);
            Console.WriteLine(caracter);
            Console.WriteLine(num1);
            Console.WriteLine(numDouble);
            Console.WriteLine(numDouble.ToString("F2")); //FnumCasas decimais
            Console.WriteLine(numDouble.ToString("F4"));
            Console.WriteLine(numDouble.ToString("F4", CultureInfo.InvariantCulture));


            //placeholders
            Console.WriteLine("{0} tem {1} anos e seu email é {2}", obj1, idade, email);
            Console.WriteLine("Saldo é {0:F2}", numDouble);//tratando casas decimais

            //Interpolação

            Console.WriteLine($"{obj1} tem {idade} e email {email} saldo {numDouble:F2}");
            */

            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";
            byte idade = 30;
            int codigo = 5698;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.90;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            Console.WriteLine($"Registro com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (tres casas decimais) : {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
