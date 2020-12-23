using System;

namespace exercici3
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 17;
            int Y = 6;
            double N = 2.2;
            double M = 3.5;

            Console.WriteLine("X={0}, Y={1}, N={2}, M={3}", X, Y, N,M);
            Console.WriteLine("Suma={0}", X+Y);
            Console.WriteLine("Resta={0}", X - Y);
            Console.WriteLine("Producto={0}", X * Y);
            Console.WriteLine("Cociente={0}", X / Y);
            Console.WriteLine("Resto={0}", X % Y);

            Console.WriteLine("Suma={0}", N + M);
            Console.WriteLine("Resta={0}", N - M);
            Console.WriteLine("Producto={0}", N * M);
            Console.WriteLine("Cociente={0}", N / M);
            Console.WriteLine("Resto={0}", N % M);

            Console.WriteLine("Suma={0}", X + N);
            Console.WriteLine("Cociente={0}", Y / M);
            Console.WriteLine("Resto={0}", Y % M);

            Console.WriteLine("Doble X={0}", X * 2);
            Console.WriteLine("Doble Y={0}", Y * 2);
            Console.WriteLine("Doble N={0}", N * 2);
            Console.WriteLine("Doble M={0}", M * 2);

            Console.WriteLine("Suma de todos={0}", X + Y + N + M);
            Console.WriteLine("Producto de todos={0}", X * Y * N * M);
        }
    }
}
