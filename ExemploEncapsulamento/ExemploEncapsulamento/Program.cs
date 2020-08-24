using System;

namespace ExemploEncapsulamento {
    class Program {
        static void Main(string[] args) {
            Cliente c = new Cliente("Dailton", "dailton@teste.com.br");

            c.Nome = "D";
            Console.WriteLine(c.Nome);


        }
    }
}
