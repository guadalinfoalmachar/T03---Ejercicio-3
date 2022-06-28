namespace T03_Eje3
{
    class T03_Eje3
    {
        static void Main()
        {
            int X = 6;
            int Y = 4;
            double N = 6.5;
            double M = 4.5;

            Console.WriteLine("Variable X = {0}", X);
            Console.WriteLine("Variable Y = {0}", Y);
            Console.WriteLine("Variable N = {0}", N);
            Console.WriteLine("Variable M = {0}", M);

            Console.WriteLine("La suma de X + Y es {0}", X+Y);
            Console.WriteLine("La diferencia de X - Y es {0}", X - Y);
            Console.WriteLine("El producto de X * Y es {0}", X * Y);
            Console.WriteLine("El cociente de X / Y es {0}", X / Y);
            Console.WriteLine("El resto de X / Y es {0}", X % Y);

            Console.WriteLine("La suma de N + M es {0}", N + M);
            Console.WriteLine("La diferencia de N - M es {0}", N - M);
            Console.WriteLine("El producto de N * M es {0}", N * M);
            Console.WriteLine("El cociente de N / M es {0}", N / M);
            Console.WriteLine("El resto de N / M es {0}", N % M);

            Console.WriteLine("El doble de X {0}", X * 2);
            Console.WriteLine("El doble de Y {0}", Y * 2);
            Console.WriteLine("El doble de N {0}", N * 2);
            Console.WriteLine("El doble de M {0}", M * 2);

            Console.WriteLine("La suma de todas las variables es {0}", X + Y + N + M);
            Console.WriteLine("El producto de todas las variables es {0}", X * Y * N * M);


            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}