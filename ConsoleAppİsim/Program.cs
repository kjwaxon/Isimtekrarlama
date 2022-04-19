using System;

namespace ConsoleAppİsim
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;

            int n;

            Console.Write("Tekrarlamak istediğiniz mesajı yazınız = ");

            x = Console.ReadLine();

            Console.Write("Kaç kere tekrarlamak istediğinizi yazınız = ");

            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
