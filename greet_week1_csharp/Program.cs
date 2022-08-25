using System;

namespace greet_week1_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mostar resultados 
            //Console.WriteLine("Hello World");

            //recepccinar valores.
            //Console.ReadLine();

            //tipo de dato !nombre de variable. !opcional - asignar valor
            //tipo de texto: 
            //char => Guarda un solo caracter.
            //string => Cadena de caracteres.
            //int => numeros enteros.
            //float, double, decimal. => numeros decimales.

            //variables
            string name;
            //entrada
            Console.Write("type your name: ");
            name = Console.ReadLine();

            //proceso ---

            //salida ----
            Console.WriteLine("Hello " + name);
            Console.ReadKey();
        }
    }
}