using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ReverseArray(1, 2, 3, 4, 5, 6, 7, 8);
        }

        static void ReverseArray(params int[] input)
        {
            if (input.Length == 0)
                return;

            int frontIndex = 0;
            int backIndex = input.Length - 1;

            PrintArray(input);
            while (frontIndex < backIndex)
            {
                Swap(input, frontIndex, backIndex);
                frontIndex++;
                backIndex--;
            }

            PrintArray(input);
        }

        private static void PrintArray(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                System.Console.WriteLine(input[i]);
            }
        }

        private static void Swap(int[] input, int frontIndex, int backIndex)
        {
            int temp = input[frontIndex];
            input[frontIndex] = input[backIndex];
            input[backIndex] = temp;
        }
    }
}
