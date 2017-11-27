/*
 * Created by SharpDevelop.
 * User: Aash
 * Date: 22-09-2017
 * Time: 09:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace functionAddSubDivMul2Num
{
	class Program
	{
		public static int a,b,c;
		public static void Main(string[] args)
		{
			
			addition();
			substraction();
			multiplication();
			divison();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void addition()
		{
			Console.WriteLine("Please Enter Value of a");
			a=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please Enter value of b");
			b=Convert.ToInt32(Console.ReadLine());
			c=a+b;
			Console.WriteLine("the addition is "+c);
		}
		public static void substraction()
		{
			c=a-b;
			Console.WriteLine("the substraction is"+c);
		}
		public static void multiplication()
		{
			c=a*b;
			Console.WriteLine("the multiplication is "+c);
		}
		public static void divison()
		{
			c=a/b;
			Console.WriteLine("the divison is f"+c);
		}
	}
}
