/*
 * Created by SharpDevelop.
 * User: Aash
 * Date: 08-09-2017
 * Time: 11:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace firstfridaysept2017
{
	class Program
	{
		public static void Main(string[] args)
		{
			//variable declairation
			string[] _name=new string[3];
			int[] _roll=new int[3];
			int[] _age=new int[3];
			int[] _fees= new int[3];
			string[] _adress=new string[3];
			int inputNum;
			//calculation
			
			for (int i = 0; i <= 2; i++) 
			{
				Console.WriteLine("----===STUDENT ID "+i+" ===----");
				Console.WriteLine("Enter Name");
				_name[i]=Console.ReadLine();
				Console.WriteLine("Enter Roll");
				_roll[i]=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Age");
				_age[i]=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Fees");
				_fees[i]=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Adress");
				_adress[i]=Console.ReadLine();
			}
			
			//output Queries
			Console.WriteLine("+++++PLEASE ENTER STUDENT ID FOR OUTPUT+++++");
			inputNum=Convert.ToInt32(Console.ReadLine());
			//Output
			Console.WriteLine("-------= STUDENT ID "+inputNum+" =-------");
			Console.WriteLine("Student Name = "+_name[inputNum]);
			Console.WriteLine("Roll Number = "+_roll[inputNum]);
			Console.WriteLine("Age = "+_age[inputNum]);
			Console.WriteLine("Fees = "+_fees[inputNum]);
			Console.WriteLine("Adress = "+_adress[inputNum]);
			Console.WriteLine("=======================================");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
