using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] array1 = new int[2, 2] { { 3, 2 }, { 1, 4 } };
            int[,] array2 = new int[2, 2] { { 9, 2 }, { 1, 7 } };

            int[,] matrixAB = Multiple(array1, array2);

            for(int i = 0; i < matrixAB.GetLength(0); i++)
            {
                for(int j = 0; j < matrixAB.GetLength(1); j++)
                {
                    Console.Write(matrixAB[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] Multiple(int[,] arr1, int[,] arr2)
        {
            int[,] result =
            {
            { arr1[0, 0] * arr2[0, 0] + arr1[0,1] * arr2[1,0] , arr1[0,0] * arr2[0,1] + arr1[0,1] * arr2[1,1]},
            { arr1[1,0] * arr2[0,0] + arr1[1,1] * arr2[1,0], arr1[1,0] * arr2[0,1] + arr1[1,1] * arr2[1,1]}
            };

            return result;
        }
    }
}
