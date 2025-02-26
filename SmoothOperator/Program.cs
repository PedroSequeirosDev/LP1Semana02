using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
            string a = Console.ReadLine("Insere número inteiro: ");
            sbyte n = sbyte.Parse(a);
            Console.WriteLine(--n);
            Console.WriteLine(++n);

        

        }
    }
}
