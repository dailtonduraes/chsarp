using System;
using System.Globalization;

namespace Exercicios01 {
    class Program {
        static void Main(string[] args) {
            /*
            Console.WriteLine("Informe o primeiro numero :");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero :");
            int num2 = int.Parse(Console.ReadLine());
            int soma = num + num2;
            Console.WriteLine($"A soma dos valores é : {soma}");*/

            //Fórmula da área: area = π.raio2
            //Considere o valor de π = 3.14159

            double pi = 3.14159;

            Console.WriteLine("Informe o dado de netrada para saber a area do circulo");
            double area = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = (pi * Math.Pow(area, 2));
            Console.WriteLine("A = " +resultado.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
