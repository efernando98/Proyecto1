//3. Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera

using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;
            int horasex;
            int resultado;
            int resultado2;
            int resultado3;

            Console.WriteLine("Ingrese sus horas de trabajo: ");
            horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese horas extra en caso de haber, sino coloque 0: ");
            horasex = Convert.ToInt32(Console.ReadLine());



            if (horas <= 40)
            {
                resultado = horas * 16;
                Console.WriteLine("Su salario normal es de Q" + resultado);
            }
            else
            {
                Console.WriteLine("Datos incorrectos.");
            }
            if (horasex > 0)
            {
                resultado2 = horasex * 20;
                resultado3 = 640 + resultado2;
                Console.WriteLine("Su salario con horas extra es de Q" + resultado3);
            }
            else
            {
                Console.WriteLine("Gracias por usar el servicio.");
            }
        }
    }
}
