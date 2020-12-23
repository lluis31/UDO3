using System;

namespace exercici2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Hello World!);
            int N = 5;
            double A = 4.56;
            char C = 'a';

            Console.WriteLine("N={0}, A={1}, C={2}", N, A, C);
            Console.WriteLine("La suma de N+A {0}", N + A);
            Console.WriteLine("La diferencia de A-N {0}", A - N);
            Console.WriteLine("El valor numerico del caracter C {0}", (int)C);
        }
    }
}
