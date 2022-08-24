using System;

namespace greet_week1_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string name;
            //entrada
            Console.Write("type your name: ");
            name = Console.ReadLine();

            //proceso ---

            //salida
            Console.WriteLine("Hello " + name);
            Console.ReadKey();
        }
    }
}