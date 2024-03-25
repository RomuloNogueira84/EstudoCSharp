using System;

namespace RomuloProcessamentoDeDadosCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 5;
            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            double b, B, h, area;
            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;
            Console.WriteLine(area);
            


            int a, c;

            double resultado;
            double resultado1;
            a = 5;
            c = 2;

            resultado = a / c;
            resultado1 = (double) a / c;
            Console.WriteLine(resultado);
            Console.WriteLine(resultado1);




            double g;
            int l;
            g = 5.0;
            l = (int)g;

            Console.WriteLine(l);
            Console.ReadLine();
        } 
    }
}
