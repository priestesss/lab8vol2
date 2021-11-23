using System;

namespace laboratorna8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[m, n];
            Console.WriteLine("d:");
            int d = Convert.ToInt32(Console.ReadLine());

            Random ran = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = ran.Next(-1, 2);
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
            /* ------------------------------------------ */
            int count_diagonal_case1 = 0;
            int count_diagonal_case2 = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && i < 0 && j < 0)
                    {
                        count_diagonal_case1++;
                    }
                    else if (i == j && i > d && j > d && i > 0 && j > 0)
                    {
                        count_diagonal_case2++;
                    }
                }
            }

            int[] diagonal_case1 = new int[count_diagonal_case1];
            int[] diagonal_case2 = new int[count_diagonal_case2 + 1];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && mas[i,j] < 0 && mas[i,j] < 0)
                    {
                        diagonal_case1[i] += mas[i, j];
                    }
                }
            }
            
            for (int i = 0; i < m + 1; i++)
            {
                int countI = i;
                for (int j = 0; j < n; j++)
                {
                    if (i == j && mas[i,j] > d && mas[i,j] > d && mas[i,j] > 0 && mas[i,j] > 0 )
                    {
                        diagonal_case2[i] += mas[countI, j];
                    }
                }
            }
            Console.WriteLine("diagonal case 1:");
            for (int i = 0; i < count_diagonal_case1; i++)
            {
                Console.Write(diagonal_case1[i]);
                Console.Write(" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("diagonal case 2:");
            for (int i = 0; i < count_diagonal_case2; i++)
            {
                Console.Write(diagonal_case2[i]);
                Console.Write(" ");
            }
            Console.WriteLine(" ");
            /* ------------------------------------------ */
            /* int copy_j = n;
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (mas[i,j] == 0)
                    {
                        int sort = mas[i, j];
                        mas[i, j] = mas[0, copy_j];
                        mas[0, copy_j] = sort;
                    }
                }
            }
            */
            Console.WriteLine("sorted mas:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}