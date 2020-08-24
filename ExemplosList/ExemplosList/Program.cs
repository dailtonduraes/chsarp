using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace ExemplosList {
    class Program {
        static void Main(string[] args) {
            List<string> times = new List<string>();

            //add list
            times.Add("Palmeiras");
            times.Add("PSG");
            times.Add("Barcelona");
            times.Add("Real Madrid");
            times.Insert(1, "Manchester");
            times.Add("Polonia");

            foreach(string t in times) {
                Console.WriteLine(t);
            }

            Console.WriteLine("List count: " + times.Count);

            string s1 = times.Find(x => x[0] == 'P' || x[0] == 'p');
            string s2 = times.FindLast(x=> x[0] =='P' || x[0] == 'p');
            int s3 = times.FindIndex(x => x[0] == 'P');
            int s4 = times.FindLastIndex(x => x[0] == 'P');

            Console.WriteLine("First 'P' " + s1);
            Console.WriteLine("Last 'P' " + s2);
            Console.WriteLine("FindIndex 'P' " + s3);
            Console.WriteLine("FindLastIndex 'P' " + s4);

            List<string> times2 = times.FindAll(x => x.Length == 3 || x[0] == 'P');
            Console.WriteLine("==================================");
            foreach (string t2 in times2) {
                Console.WriteLine(t2);
            }

            Console.WriteLine("==============================");
            //times.Remove("PSG");
            //times.RemoveAt(3);
            times.RemoveRange(1,2);
            foreach (string t in times) {
                Console.WriteLine(t);
            }

            Console.WriteLine("==============================");
            times.RemoveAll(x => x[0] == 'P');
            foreach (string t in times) {
                Console.WriteLine(t);
            }

            /*static bool Test(string s) {
                return s[0] == 'P';
            }*/
        }
    }
}
