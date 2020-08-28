using AbstractClassAndMethods.Entities;
using AbstractClassAndMethods.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the namber of shapes");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1;  i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)?");
                char tp = char.Parse(Console.ReadLine());
                Console.Write("Color: (Black/Blue/Red) ?");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(tp == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                if(tp == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Shape Areas");

            foreach (Shape sh in list)
            {
                Console.WriteLine(sh.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
