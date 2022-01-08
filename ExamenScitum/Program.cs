using System;

namespace ExamenScitum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ScitumExamen");
            Console.WriteLine("Ejercicio 1:\n");
            EjercicioUno.Execute();
            Console.WriteLine("\nEjercicio 2:\n");
            EjercicioDos.Execute();
            Console.WriteLine("\nEjercicio 3:\n");
            EjercicioTres.Execute();
            Console.ReadLine();
        }
    }
}
