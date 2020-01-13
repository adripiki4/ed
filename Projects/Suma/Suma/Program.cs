using System;

namespace Suma
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("introduzca un numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca un numero");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("la suma es: " + (a + b));
            Console.WriteLine("la resta es: " + (a - b));

            Console.WriteLine("introduzca un numero");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("introduzca un numero");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("la multiplicacion es: " + (c * d));
            Console.WriteLine("la division es: " + (c / d));

        }
    }
}
