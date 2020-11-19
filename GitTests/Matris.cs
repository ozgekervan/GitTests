using System;

namespace GitTests
{
    public class Matris
    {
        private int[,] M { get; set; }
        public Matris(int n=3)
        {
            M = new int[n, n];
            DegerAta();
        }

        public void Yazdir()
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(0); j++)
                {
                    Console.Write("{0,5}",M[i,j]);
                }
                Console.WriteLine();
            }
        }

        private void DegerAta(int min=1, int max=9)
        {
            for (int i = 0; i < M.GetLength(0); i++)
                for (int j = 0; j < M.GetLength(0); j++)
                    M[i, j] = new Random().Next(min, 9);
        }

        public void Transpoz()
        {
            // TODO:
        }
    }
}