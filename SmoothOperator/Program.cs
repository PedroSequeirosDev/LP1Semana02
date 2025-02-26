using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
            Console.WriteLine("Insere número inteiro:");
            string a = Console.ReadLine();
            sbyte n = sbyte.Parse(a);
            Console.WriteLine(--n);
            Console.WriteLine(++n);

        

        }
    }
}
