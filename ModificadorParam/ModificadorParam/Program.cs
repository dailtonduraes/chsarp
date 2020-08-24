using System;

namespace ModificadorParam {
    class Program {
        static void Main(string[] args) {
            int s1 = Calculator.sum(1, 2, 3);
            int s2 = Calculator.sum(3, 8, 9);
            int a = 10;
            
            Calculator.triple(ref a);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(a);

            string[] vect = new string[] {"aline", "maria", "cirilo" };

            foreach (string nomes in vect) {
                Console.WriteLine(nomes);
            }
           

        }
    }
}
