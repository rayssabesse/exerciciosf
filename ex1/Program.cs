using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = DateTime.Now.Year;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Em qual ano você nasceu?");
            Console.ForegroundColor = ConsoleColor.White;
            int byear = int.Parse(Console.ReadLine());

            int age = year - byear;

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Você tem " + age + " anos. Você DEVE votar.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (age >= 16 && age < 18)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Você tem " + age + " anos. Você PODE votar.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (age < 16)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Você tem " + age + " anos. Você NÃO PODE votar.");
                Console.ForegroundColor = ConsoleColor.White;
            }


        }
    }
}
