using System;

namespace Ejercicio4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla 
            // si los mismos se encuentran ordenados de forma decreciente .
            
            int a, b, c, d;

            Console.WriteLine("Ingresar el 1º numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el 1º numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el 1º numero");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el 1º numero");
            d = int.Parse(Console.ReadLine());
            
            if (a > b && b > c && c > d)
                Console.WriteLine("Los numeros estan ordenados decrecientemente");
            else
                Console.WriteLine("Los numeros no estan ordenados de forma decreciente");

            Console.WriteLine("Fin del programa");
        }
    }
}
