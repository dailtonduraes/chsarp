using System;
using System.Globalization;

namespace ExercicioClass {
    class Program {
        static void Main(string[] args) {
            /*
             *EXERCICIO 1
             *
             *
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeia Pessoa 1");
            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());
            pessoa1.genero = char.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeia Pessoa 2");
            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());
            pessoa2.genero = char.Parse(Console.ReadLine());

            Console.WriteLine($"Nome: {pessoa1.nome} \n Idade: {pessoa1.idade} \n Genero: {pessoa1.genero}");
            Console.WriteLine($"Nome: {pessoa2.nome} \n Idade: {pessoa2.idade} \n Genero: {pessoa2.genero}");

            string maisvelho;
            if(pessoa1.idade > pessoa2.idade) {
                maisvelho = $"A pessoa mais velha é {pessoa1.nome}";
            }
            else {
                maisvelho = $"A pessoa mais velha é {pessoa2.nome}";
            }
            Console.WriteLine(maisvelho);*/

            Funcionario fun1, fun2;
            fun1 = new Funcionario();
            fun2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario");
            fun1.nome = Console.ReadLine();
            fun1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario");
            fun2.nome = Console.ReadLine();
            fun2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nome: {0} \n Salário: {1} ", fun1.nome, fun1.salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Nome: {0} \n Salário: {1} ", fun2.nome, fun2.salario.ToString("F2", CultureInfo.InvariantCulture));

            double mediaSalario = (fun1.salario + fun2.salario) / 2.0;

            Console.WriteLine("O salário medio é " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
