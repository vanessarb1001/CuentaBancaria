using System;

namespace CuentaBancaria
{
	public class Cuenta
	{
		private string nombre;
		private double balance;
		
		public Cuenta()
		{
			this.nombre="";
			this.balance=0.00;
		}
		
		public Cuenta(string nombre, double balance)
		{
			this.nombre=nombre;
			this.balance=balance;
		}
		
		
		public string Nombre {
			get {
				return nombre;
			}
			set {
				nombre = value;
			}
		}
		
		
		public double Balance {
			get {
				return balance;
			}
			set {
				balance = value;
			}
		}
		
		public void Depositar()
		{
			Console.Write("¿Cuanto desea ingresar en su cuenta? ");
			double deposito = double.Parse(Console.ReadLine());
			
			Balance = Balance + deposito;
			
			Console.WriteLine("Ha ingresado " + deposito + " pesos en su cuenta");
		}
		
		public void Retirar()
		{
			Console.Write("¿Cuanto desea retirar de su cuenta? ");
			double retiro = double.Parse(Console.ReadLine());
			
			if (retiro <= Balance) 
			{
				Balance = Balance - retiro;
				Console.WriteLine("El proceso de retiro ha sido un exito");
			}
			else
			{
				Console.WriteLine("Lo sentimos, no puede retirar más del saldo actual");
			}
		}
		
		
	}
}
