using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperacionesCon2Numeros_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el operando 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el operando 2:");
            int num2 = int.Parse(Console.ReadLine());



            int suma = num1 + num2;
            int resta = num1 - num2;
            int multi = num1 * num2;
            int divi = num1 / num2;
            int resto = num1 % num2;

            Console.WriteLine("¿Qué operación quieres hacer?");
            string respuesta = Console.ReadLine();

            switch (respuesta.ToLower())
            {
                case "suma":
                    Console.WriteLine($"SUMA: {suma}");
                    break;
                case "resta":
                    Console.WriteLine($"RESTA: {resta}");
                    break;
                case "multiplicacion":
                    Console.WriteLine($"MULTIPLICACIÓN: {multi}");
                    break;
                case "division":
                    Console.WriteLine($"DIVISIÓN: {divi}");
                    break;
                case "resto":
                    Console.WriteLine($"RESTO: {resto}");
                    break;
            }

            
            
            
            
            
        }
    }
}
