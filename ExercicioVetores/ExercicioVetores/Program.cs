using System;

namespace ExercicioVetores {
    class Program {
        static void Main(string[] args) {
            Room[] numRooms = new Room[10];

            Console.Write("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n;i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                numRooms[quarto] = new Room(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos oculpados:");
            for (int i = 0; i< numRooms.Length;i++) {
                if(numRooms[i] != null) {
                    Console.WriteLine(i + ": " + numRooms[i]);
                }
            }
            
        }
    }
}
