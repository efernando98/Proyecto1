//6. Pide un número por teclado e indica si es un número primo o no

using System;

namespace Numeroprimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un numero: ");
            numero = (Convert.ToInt32(Console.ReadLine()));

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero no es primo: " + numero);
            }
            else
            {
                Console.WriteLine("El numero es primo: " + numero);
            }
        }
    }
}
