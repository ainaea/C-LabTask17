using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum of 1, 4, 9, 16, 9, 7, 4, 9, 11 is {AlternateSum(new int[]{1, 4, 9, 16, 9, 7, 4, 9, 11})} ");
        }

        static int AlternateSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = i % 2 == 0? sum + arr[i]:  sum - arr[i];
            }
            return sum;
        }
    }
}
