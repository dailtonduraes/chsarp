using System;
using System.Globalization;

namespace FuncoesString {
    class Program {
        static void Main(string[] args) {

            /*
            string original = "abcde FGHIJ ABC abc DEFG      ";

            string toUpper = original.ToUpper();
            string toLower = original.ToLower();

            Console.WriteLine(original);
            Console.WriteLine(toUpper);
            Console.WriteLine(toLower);*/

            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.ParseExact("2000-08-10", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d3 = DateTime.Parse("2000-05-23 00:03:18");

            //TimeSpan
            TimeSpan t1 = new TimeSpan(0, 1, 40);
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(1000000000L);
            TimeSpan t4 = new TimeSpan(1, 2, 40, 30);

            //TimeSpan.from

            TimeSpan t5 = TimeSpan.FromDays(2.5);
            TimeSpan t6 = TimeSpan.FromHours(2);

            //Propriedades DateTime
            DateTime d = new DateTime(2000, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine("==================");
            Console.WriteLine(d);
            Console.WriteLine("(1) Date " +d.Date);
            Console.WriteLine("(2) Day " +d.Day);
            Console.WriteLine("(3) DayOfWeek " +d.DayOfWeek);
            Console.WriteLine("(4) Month " +d.Month);
            Console.WriteLine("(5) Year " +d.Year);

            Console.WriteLine("=============");
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            Console.WriteLine("=========================");
            DateTime dtAtual = DateTime.Now;
            DateTime dtVencimento = dtAtual.AddDays(3);
            Console.WriteLine("Data atual " + dtAtual);
            Console.WriteLine("Data vencimento " + dtVencimento);

            Console.WriteLine("=============================");
            Console.WriteLine("Diferença entre duas datas");

            DateTime dt1 = new DateTime(2018, 3, 10);
            DateTime dt2 = new DateTime(2018, 3, 14);

            TimeSpan dDiff = dt2.Subtract(dt1);

            Console.WriteLine("a diferença é " + dDiff.Days);



        }
    }
}
