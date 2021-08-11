using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr = { { 1, 1, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, }, { 1, 1, 1, 0, 0, 0 }, { 0, 0, 2, 4, 4, 0 }, { 0, 0, 0, 2, 0, 0 }, { 0, 0, 1, 2, 4, 0 } };

            int[][] arr = new int[6][];
            arr[0] = new int[6] { 1, 1, 1, 0, 0, 0 };
            arr[1] = new int[6] { 0, 1, 0, 0, 0, 0, };
            arr[2] = new int[6] { 1, 1, 1, 0, 0, 0 };
            arr[3] = new int[6] { 0, 0, 2, 4, 4, 0 };
            arr[4] = new int[6] { 0, 0, 0, 2, 0, 0 };
            arr[5] = new int[6] { 0, 0, 1, 2, 4, 0 };


            var result = hourglassSum(arr);
        }

        static int hourglassSum(int[][] arr)
        {

            int maxHourglassSum = -63;
            Console.WriteLine(arr[3][2]);
            for (int i = 0; i + 2 < arr.Length; i++)
            {

                for (int j = 0; j + 2 < arr[i].Length; j++)
                {
                    int hrGlassSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    Console.WriteLine("HourglassSum= " + hrGlassSum + " i=" + i + " j=" + j);
                    if (maxHourglassSum < hrGlassSum)
                    {
                        maxHourglassSum = hrGlassSum;
                    }
                }
            }

            return maxHourglassSum;

        }
    }


}
