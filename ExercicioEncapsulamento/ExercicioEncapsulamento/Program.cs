using System;
using System.Globalization;

namespace ExercicioEncapsulamento {
    class Program {
        static void Main(string[] args) {
            ContaBancaria conta;
            Console.Write("Entre com o Número da conta ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (s/n)");
            char decisao = char.Parse(Console.ReadLine());

            if(decisao == 's' || decisao == 'S') {
                Console.Write("Entre com o valor do deposito inicial:");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, deposito);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.Write("Entre com um valor para deposito:");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados atualizados da conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque:");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados da conta");
            Console.WriteLine(conta);
        }
    }
}
