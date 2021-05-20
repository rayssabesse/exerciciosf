using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira 15 numeros:");

            int[] numbers = new int[15];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Digite o {(i + 1)}° numero");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (var i = (numbers.Length - 1); i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
