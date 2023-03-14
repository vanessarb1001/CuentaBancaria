using System;

namespace CuentaBancaria
{
	class CuentaTester
	{
		public static void Main(string[] args)
		{
			int opcion=0;
			
			Cuenta banco = new Cuenta();
			
			Console.WriteLine("Ingrese su nombre por favor:");
			banco.Nombre = Console.ReadLine();
			
			do
			{
				Console.Clear();
				
				Console.WriteLine("Bienvenido al sistema " +banco.Nombre);

				Console.WriteLine("1- Para consultar Balance");
				Console.WriteLine("2- Para hacer un deposito");
				Console.WriteLine("3- Para hacer un retiro de cuenta");
				Console.WriteLine("4- Para salir del sistema");
				
				Console.Write("Seleccione la opcion de us preferencia -> ");
				opcion = int.Parse(Console.ReadLine());
				
				switch (opcion)
				{
					case 1:
						if (banco.Balance >= 1.00)
						{
							Console.WriteLine("Su Balance actual es de: " +banco.Balance+ " pesos. ");
						}
						else
						{
							Console.WriteLine("Su cuenta está vacia");
						}
						break;
					case 2:
						Console.WriteLine("Ha elegido hacer deposito");
						banco.Depositar();
						break;
					case 3:
						Console.WriteLine("Ha decidido retirar");
						banco.Retirar();
						break;
					case 4:
						Console.WriteLine("Ha elegido salir");
						break;
					default:
						Console.WriteLine("\n Opcion no valida!");
						break;
				}
				
				Console.WriteLine("Pulsa una tecla cualquiera para poder regresar al menú");
				Console.ReadKey();
				Console.Clear();
				
			} while(opcion != 4);
			Console.WriteLine("Gracias por preferirnos, usuario " +banco.Nombre);
			Console.ReadKey();
		}
	}
}