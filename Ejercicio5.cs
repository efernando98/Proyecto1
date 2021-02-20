//5. Crea una aplicación que nos pida un día de la semana y que nos diga si es un dia laboral o no

using System;

namespace Dialaboral
{
    class Program
    {
        static void Main(string[] args)
        {
            int día;

            Console.WriteLine("1. Lunes");
            Console.WriteLine("2. Martes");
            Console.WriteLine("3. Miércoles");
            Console.WriteLine("4. Jueves");
            Console.WriteLine("5. Viernes");
            Console.WriteLine("6. Sábado");
            Console.WriteLine("7. Domingo");
            Console.WriteLine("Ingrese un día de la semana por numero: ");
            día = Convert.ToInt32(Console.ReadLine());

            switch (día)
            {
                case 1:
                    Console.WriteLine("Es un dia laboral");
                    break;

                case 2:
                    Console.WriteLine("Es un dia laboral");
                    break;

                case 3:
                    Console.WriteLine("Es un dia laboral");
                    break;

                case 4:
                    Console.WriteLine("Es un dia laboral");
                    break;

                case 5:
                    Console.WriteLine("Es un dia laboral");
                    break;

                case 6:
                    Console.WriteLine("No es un dia laboral");
                    break;

                case 7:
                    Console.WriteLine("No es un dia laboral");
                    break;

                default:
                    Console.WriteLine("No ha seleccionado una opción válida.");
                    break;
            }
        }
    }
}
