using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite 10 números: ");
            Console.ForegroundColor = ConsoleColor.White;
            int[] numbers = new int[10];

            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("O menor número é: " + numbers[0]);
            Console.WriteLine("O menor número é: " + numbers[9]);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
