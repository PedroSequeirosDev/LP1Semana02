using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"Max valor int: {int.MaxValue}");   
            Console.WriteLine($"Min valor int: {int.MinValue}");
            Console.WriteLine($"Max valor long: {long.MaxValue}");
            Console.WriteLine($"Min valor long: {long.MinValue}");
            Console.WriteLine($"Max valor float: {float.MaxValue}");
            Console.WriteLine($"Min valor float: {float.MinValue}");
            Console.WriteLine($"Max valor decimal: {decimal.MaxValue}");
            Console.WriteLine($"Min valor decimal: {decimal.MinValue}");
            Console.WriteLine($"Max valor sbyte: {sbyte.MaxValue}");
            Console.WriteLine($"Min valor sbyte: {sbyte.MinValue}");
            Console.WriteLine($"Max valor short: {short.MaxValue}");
            Console.WriteLine($"Min valor short: {short.MinValue}");
            Console.WriteLine($"Max valor byte: {byte.MaxValue}");
            Console.WriteLine($"Min valor byte: {byte.MinValue}");
            Console.WriteLine($"Max valor ushort: {ushort.MaxValue}");
            Console.WriteLine($"Min valor ushort: {ushort.MinValue}");
            Console.WriteLine($"Max valor uint: {uint.MaxValue}");
            Console.WriteLine($"Min valor uint: {uint.MinValue}");
            Console.WriteLine($"Max valor ulong: {ulong.MaxValue}");
            Console.WriteLine($"Min valor ulong: {ulong.MinValue}");
            Console.WriteLine($"Max valor double: {double.MaxValue}");
            Console.WriteLine($"Min valor double: {double.MinValue}");
            Console.WriteLine($"Min valor char: {char.MinValue}");
            Console.WriteLine($"Max valor char: {double.MaxValue}");
            Console.WriteLine($"Float inf positivo:{float.PositiveInfinity}");
            Console.WriteLine($"Float inf negativo:{float.NegativeInfinity}");
            Console.WriteLine($"Float NaN:{float.NaN}");
            Console.WriteLine($"Double inf positivo:{double.PositiveInfinity}");
            Console.WriteLine($"Double inf negativo:{double.NegativeInfinity}");
            Console.WriteLine($"Double NaN:{double.NaN}");
            

            uint i = uint.MaxValue;
            Console.WriteLine(i);
            Console.WriteLine((uint)(i+1));
            Console.WriteLine((uint)(i+5));

        }
    }
}
