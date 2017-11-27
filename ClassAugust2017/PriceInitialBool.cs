/*
 * Created by SharpDevelop.
 * User: Aash
 * Date: 18-08-2017
 * Time: 10:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace class_workp_1
{
	class Program
	{
		public static void Main(string[] args)
		{ 
			int _num1, _num2; //d
			string _name; 
			double _price; //d
			char _initials='C';
			bool _iscorrect=true;
			
			Console.WriteLine("Enter the num1 value");
			_num1=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the num2 value");
			_num2=Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Enter the name ");
			_name=Console.ReadLine();
			
			Console.WriteLine("Enter the price value");
			_price=Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Enter the initials value");
			_initials=Convert.ToChar(Console.ReadLine());
			
			Console.WriteLine("Enter the check value");
			_iscorrect=Convert.ToBoolean(Console.ReadLine());
			
			//printing inputs
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
