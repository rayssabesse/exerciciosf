using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "Qual o combustível que deseja?\n" +
                "Digite 'A' para álcool\n" +
                "Digite 'G' para gasolina"
            );
            Console.ForegroundColor = ConsoleColor.White;
            string c = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "\nQuantos litros deseja abastecer?"
            );
            Console.ForegroundColor = ConsoleColor.White;
            double l = double.Parse(Console.ReadLine());

            double alcool = 4.90;
            double gasolina = 5.30;

            switch (c)
            {
                case "A":
                    if (l < 20)
                    {
                        double d = l * ((alcool * 3) / 100);
                        double sd = l * alcool;
                        double vt = sd - d;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nO valor total é de: R$" + vt);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (l >= 20)
                    {
                        double d = l * ((alcool * 5) / 100);
                        double sd = l * alcool;
                        double vt = sd - d;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nO valor total é de: R$" + vt);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                case "G":
                    if (l < 20)
                    {
                        double d = l * ((gasolina * 4) / 100);
                        double sd = l * gasolina;
                        double vt = sd - d;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nO valor total é de: R$" + vt);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (l >= 20)
                    {
                        double d = l * ((gasolina * 5) / 100);
                        double sd = l * gasolina;
                        double vt = sd - d;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nO valor total é de: R$" + vt);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
            }
        }
    }
}
