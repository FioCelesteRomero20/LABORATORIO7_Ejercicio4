using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO7_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca un numero: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                Console.Write("Ingrese un número: ");
                int num = int.Parse(Console.ReadLine());
                for (int j = 0; j < num; j++)
                {
                    
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    } 
}
