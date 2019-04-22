using System;
using System.Text;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ReverseArray(1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine(CompressString("aaaabbbccd33eeffgg"));
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

        // Abbbccd3effgg | Ab3c2d3ef2g2
        private static string CompressString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char lastChar = input[0];

            int currIndex = 1;
            int totalCount = 1;
            StringBuilder encString = new StringBuilder(input.Length);
            // Abbbccd3effgg | Ab3c2d3ef2g2

            while (currIndex < input.Length)
            {
                if (lastChar == input[currIndex])
                {
                    totalCount++;

                }
                else
                {
                    encString.Append($"{lastChar}{totalCount}");
                    System.Console.WriteLine($"Current String: {lastChar}{totalCount}");
                    totalCount = 1;
                    lastChar = input[currIndex];
                }

                currIndex++;
                if (currIndex == input.Length)
                    encString.Append($"{lastChar}{totalCount}");
            }
            return encString.Length < input.Length ? encString.ToString() : input;
        }
    }
}
