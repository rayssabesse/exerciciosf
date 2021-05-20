using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva 10 nomes: ");
            string[] name = new string[10];

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"Digite o {(i + 1)}° nome");
                name[i] = Console.ReadLine();
            }

            Console.WriteLine("Qual nome deseja procurar?");
            string searchname = Console.ReadLine();

            bool f = false;

            foreach (var ename in name)
            {
                if (ename == searchname)
                {
                    f = true;
                }
            }

            if (f == true)
            {
                Console.WriteLine("ACHEI");
            }
            else
            {
                Console.WriteLine("NÃO ACHEI");
            }





        }
    }
}
