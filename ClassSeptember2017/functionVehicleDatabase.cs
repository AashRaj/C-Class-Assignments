/*
 * Created by SharpDevelop.
 * User: Aash
 * Date: 18-09-2017
 * Time: 14:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace functionVehicleDatabase
{
	class Program
	{
		public static string[] vehicleDatabase=new string[5];
		public static void Main(string[] args)
		{
			DataIn();
			DataOut();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void DataIn()
		{
			Console.WriteLine("Please Enter name of Vehichle");
			vehicleDatabase[0]=Console.ReadLine();
			Console.WriteLine("Please Enter Model");
			vehicleDatabase[1]=Console.ReadLine();
			Console.WriteLine("Please Enter Mileage");
			vehicleDatabase[2]=Console.ReadLine();
			Console.WriteLine("Please Enter Capacity");
			vehicleDatabase[3]=Console.ReadLine();
			Console.WriteLine("Please Enter Horsepower");
			vehicleDatabase[4]=Console.ReadLine();
			
		}
		public static void DataOut()
		{
			Console.WriteLine("Name ="+vehicleDatabase[0]);
			Console.WriteLine("Model ="+vehicleDatabase[1]);
			Console.WriteLine("Mileage ="+vehicleDatabase[2]);
			Console.WriteLine("Capacity ="+vehicleDatabase[3]);
			Console.WriteLine("Horsepower ="+vehicleDatabase[4]);
		}
	}
}
