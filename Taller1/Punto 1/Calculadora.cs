using System;

namespace Calculadora
{
    class P
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.Write("Dame el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Dame el operador (+, -, *, /): ");
            char operador = char.Parse(Console.ReadLine());

            Console.Write("Dame el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;

            try
            {
                switch (operador)
                {
                    case '+':
                        resultado = num1 + num2;
                        break;
                    case '-':
                        resultado = num1 - num2;
                        break;
                    case '*':
                        resultado = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: División entre cero no permitida.");
                            return;
                        }
                        resultado = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Operador no válido.");
                        return;
                }

                Console.WriteLine($"Resultado: {resultado}");
                
                if (Math.Floor(resultado) == resultado) 
                {
                    Console.WriteLine($"Resultado en fracción: {ConvertirAFraccion(resultado)}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese números válidos y un operador válido.");
            }
        }

        static string ConvertirAFraccion(double numero)
        {
            int denominador = 1000000; 
            int numerador = (int)(numero * denominador);
            int mcd = MCD(numerador, denominador);
            numerador /= mcd;
            denominador /= mcd;

            return $"{numerador}/{denominador}";
        }

        static int MCD(int a, int b)
        {
            if (b == 0)
                return a;
            return MCD(b, a % b);
        }
    }
}
