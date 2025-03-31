using System;

namespace CSharpPrograms
{
    class ArrayPrograms
    {
        static void Main(string[] args)
        {
            // 1 Dimensional Array

            /*int[] a = { 10, 20, 30, 40, 50 };

            // foreach (int i in a)
            // {
            //     Console.Write(i + ",");
            // }

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ",");
            } */

            // 2 Dimensional Array

            int[,] a = new int[2, 2];

            // Row Nested For Loop
            for (int i = 0; i < 2; i++)
            {
                // Column Nested For Loop
                for (int j = 0; j < 2; j++)
                {
                    // I don't want output as i want to give input
                    a[i, j] = Convert.ToInt32(Console.ReadLine());


                }

            }
            // Row Nested For Loop
            for (int i = 0; i < 2; i++)
            {
                // Column Nested For Loop
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(a[i, j]);


                }
                Console.WriteLine();
            }

        }


    }



}