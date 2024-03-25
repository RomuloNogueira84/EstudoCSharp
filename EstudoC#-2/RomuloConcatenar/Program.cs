using System;
using System.Globalization;

namespace RomuloConcatenar
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.98765;
            int y = 39;
            string z = "Romulo";
            char w = 'M';
            string k = "Masculino";
            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
            Console.WriteLine();
            Console.WriteLine("O paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
            Console.WriteLine("Eu sou " + z + " estou com " + y + " anos de idade e sou do sexo " + k +"!");
            Console.ReadLine();
        }
    }
}