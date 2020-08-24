using System;

namespace StructsDados {
    class Program {
        static void Main(string[] args) {
            Point p;
            p.X = 10;
            p.Y = 20;

            //Trabalhando com Nullable
            Nullable<double> x = null;

            //forma mais simples nullable opcional
            double? y = 10;

            //operador de coalescência nula

            double a = x ?? 0.5;
            double b = y ?? 20;


            Console.WriteLine(p);
            Console.WriteLine();
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("x é null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("y é null");

            //
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
