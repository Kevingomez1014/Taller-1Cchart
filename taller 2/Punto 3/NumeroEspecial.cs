// See https://aka.ms/new-console-template for more information
using System;

namespace NumeroEspecial
{
    class P
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comprobador de Número Especial");
            Console.Write("Dame un número: ");
            int numero = int.Parse(Console.ReadLine());

            bool DivisibleEntre5 = numero % 5 == 0;
            bool noEsDivisible = numero % 2 != 0 && numero % 3 != 0;

            int sumaDigitos = CalcularSumaDigitos(numero);

            bool sumaMayor = sumaDigitos > 10;

            if (DivisibleEntre5 && noEsDivisible && sumaMayor)
            {
                Console.WriteLine("El número ingresado es especial.");
            }
            else
            {
                Console.WriteLine("El número ingresado NO es especial.");
            }
        }

        static int CalcularSumaDigitos(int num)
        {
            int suma = 0;
            while (num != 0)
            {
                suma += num % 10;
                num /= 10;
            }
            return suma;
        }
    }
}
