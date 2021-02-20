//2. En MegaPlaza se hace un 20% de descuento a los clientes  cuya compra supere los 300

using System;

namespace Descuento
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int descuento;
            int resultado;

            Console.WriteLine("Introduzca el total de su compra: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= 300)
            {
                descuento = num1 * 20 / 100;
                resultado = 300 - descuento;
                Console.WriteLine("Se le ha descontado el 20% de descuento por compras mayores a 300: " + resultado);
            }

            else
            {
                Console.WriteLine("El total de su compra es de: " + num1);
            }
        }
    }
}
