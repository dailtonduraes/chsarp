using System;

namespace ExemploMatrizes {
    class Program {
        static void Main(string[] args) {


            Console.Write("Informe a quantidade da matriz");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();


            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if(mat[i,j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers " + count);


            /* string[,] mat = new string[2, 3];

             Console.WriteLine(mat.Length);
             Console.WriteLine("rank numero de dimensoes da matriz " +mat.Rank); // 
             Console.WriteLine("quantidade de linhas da primeira coluna " +mat.GetLength(0)); //
             Console.WriteLine("qtd linhas segunda coluna " + mat.GetLength(1)); //
             Console.WriteLine("qtd linhas terceira coluna " + mat.GetLength(2)); //*/
        }
    }
}
