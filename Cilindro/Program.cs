using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
             Console.WriteLine("Insira a altura do cilindro ");
             string a = Console.ReadLine();
             Console.WriteLine("Insira o raio do cilindro  ");
             string r = Console.ReadLine();

             double a_convert = double.Parse(a);
             double r_convert = double.Parse(r);
             double pi = Math.PI;


             double V = a_convert *Math.Pow(r_convert,2) * pi;
             
             Console.WriteLine (V);


        }
    }
}
