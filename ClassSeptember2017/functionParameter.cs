/*
 * Created by SharpDevelop.
 * User: Aash
 * Date: 18-09-2017
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace functionParameter
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a, b ,c,d;
			Console.WriteLine("Enter value of a");
			a=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter value of b");
			b=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter value of c");
			c=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter value of d");
			d=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(func1(a, b,c , d));
			Console.WriteLine(func2(a, b,c ,d));
			Console.WriteLine(func3(a,b,c));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static int func1(int a,int b,int c ,int d)
		{
			return a+b+c+d;
		}
		public static int func2(int a,int b,int c ,int d)
		{
			return a-b-c+d;
		}
		public static int func3(int a,int b,int c)
		{
			return a*b*c;
		}
	}
}
