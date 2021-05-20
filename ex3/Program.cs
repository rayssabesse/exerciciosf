using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Qual o nome do produto?");
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Quantos produtos deseja comprar?");
            Console.ForegroundColor = ConsoleColor.White;
            int q = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Qual o valor do produto?");
            Console.ForegroundColor = ConsoleColor.White;
            double p = double.Parse(Console.ReadLine());

            double t1 = q * p;

            double d = 0;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("O valor do produto é de: R$" + t1);
            Console.ForegroundColor = ConsoleColor.White;

            if (q <= 5)
            {
                d = ((p * 2) / 100);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O valor do desconto é de: R$" + d);
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (q > 5 && q <= 10)
            {
                d = ((p * 3) / 100);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O valor do desconto é de: R$" + d);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (q > 10)
            {
                d = ((p * 5) / 100);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O valor do desconto é de: R$" + d);
                Console.ForegroundColor = ConsoleColor.White;
            }

            double t = t1 - d;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("O total a pagar é de: R$" + t);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
