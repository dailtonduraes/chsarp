using System;
using System.Globalization;

namespace ExcerciciosEstatic {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos dolares você vai comprar");
            double valorCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = " +
                Calculadora.ConversorMoeda(valorCompra).ToString("F2", CultureInfo.InvariantCulture)
                );
        }
    }
}
