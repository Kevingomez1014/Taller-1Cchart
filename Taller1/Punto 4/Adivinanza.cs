// See https://aka.ms/new-console-template for more information
using System;

namespace Adivinanza
{
    class Program
    {
        static void Main(string[] args)
        {
            string F_Original = "nacional es mejor equipo de colombia es el rey de copas ";
            string[] P_Ocultas = { "el", "rey", "de","equipo","es","mejor" };

            Console.WriteLine("Adivinanza de Frase Oculta");
            Console.WriteLine($"La frase que se muestra es: {Obtener_F_Oculta(F_Original, P_Ocultas, new string[P_Ocultas.Length])}");

            for (int intentos = 10; intentos > 0; intentos--)
            {
                Console.WriteLine($"\nIntentos restantes: {intentos}");
                Console.Write("Ingresa una palabra: ");
                string P_Ingresada = Console.ReadLine().ToLower();

                if (Array.Exists(P_Ocultas, palabra => palabra == P_Ingresada))
                {
                    int indexPalabra = Array.IndexOf(P_Ocultas, P_Ingresada);
                    Console.WriteLine($";) Correcto has adivinado la palabra '{P_Ocultas[indexPalabra]}'.");
                    P_Ocultas[indexPalabra] = ""; // Marcar la palabra como adivinada
                }
                else
                {
                    Console.WriteLine("Incorrecto sigue intentando.");
                }

                if (Array.TrueForAll(P_Ocultas, palabra => string.IsNullOrEmpty(palabra)))
                {
                    Console.WriteLine($";)Felicitaciones has adivinado todas las palabras.");
                    Console.WriteLine($"La frase completa es: {F_Original}");
                    break;
                }
            }

            Console.WriteLine(";) Fin del juego.");
        }

        static string Obtener_F_Oculta(string F_Original, string[] P_Ocultas, string[] P_Adivinadas)
        {
            string F_Oculta = F_Original;
            for (int i = 0; i < P_Ocultas.Length; i++)
            {
                if (string.IsNullOrEmpty(P_Adivinadas[i]))
                {
                    F_Oculta = F_Oculta.Replace(P_Ocultas[i], "____");
                }
                else
                {
                    F_Oculta = F_Oculta.Replace(P_Ocultas[i], P_Adivinadas[i]);
                }
            }
            return F_Oculta;
        }
    }
}

