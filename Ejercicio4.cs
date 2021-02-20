//4. Un año es bisiesto si es divisible por 4  excepto aquellos divisibles por 100 pero no por 400  Según el año determine la cantidad de dias de un mes

using System;


namespace Añobisiesto
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("calcular bisiestos \n");
			Console.WriteLine("año a calcular \n");
			string ano1 = Console.ReadLine();
			Console.WriteLine("año final a calcular \n");
			string ano2 = Console.ReadLine();
			for (int a = Convert.ToInt32(ano1); a <= Convert.ToInt32(ano2); a++)
			{


				if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
				{
					Console.WriteLine("Es bisiesto {0}\n", a);
				}
				else
				{
					Console.WriteLine("no es bisiesto {0} \n", a);
				}
			}


			Console.ReadKey();
		}
	}
}
