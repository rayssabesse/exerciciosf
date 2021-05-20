using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
    
            

            for (var i = 1; i < 11; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTABUADA DO " + i);
                Console.ForegroundColor = ConsoleColor.White;

                for (var c = 1; c < 11; c++)
                {
                    Console.WriteLine();
                    Console.Write(i);
                    Console.Write(" * ");
                    Console.Write(c);
                    Console.Write(" = ");
                    Console.Write(i * c);
                }
            }

        }
    }
}
