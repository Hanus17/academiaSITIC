using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine(SumInteger(out a, ref b));
            Console.WriteLine("Valor de a:" + a);
            Console.ReadKey();
        }

        public static int SumInteger(out int a, ref int b)
        {
            a = b;
            return a + b;
        }
    }
}
