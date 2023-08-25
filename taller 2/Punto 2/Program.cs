// See https://aka.ms/new-console-template for more information
using System;

namespace TablasMultiplicar
{
    class P
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tablas de Multiplicar");
            Console.Write("Dame el valor inicial del rango: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Dame el valor final del rango: ");
            int fin = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int numero = inicio; numero <= fin; numero++)
            {
                int resultadoPorEncontrar = random.Next(1, 11); 
                Console.WriteLine($"Tabla de multiplicar del {numero}:");

                for (int i = 1; i <= 10; i++)
                {
                    if (i == resultadoPorEncontrar)
                    {
                        Console.WriteLine($"{numero} x ? = {numero * i}");
                    }
                    else
                    {
                        Console.WriteLine($"{numero} x {i} = {numero * i}");
                    }
                }

                Console.Write("Dame el número que completa la operación: ");
                int respuesta = int.Parse(Console.ReadLine());

                if (respuesta == resultadoPorEncontrar)
                {
                    Console.WriteLine("Correcto");
                }
                else
                {
                    Console.WriteLine($"Fallaste. El resultado era {resultadoPorEncontrar}. ");
                }
            }
        }
    }
}

