/*
 * Created by SharpDevelop.
 * User: Aash
 * Date: 28-08-2017
 * Time: 09:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dxxdwdxw
{
	class Program
	{
		public static void Main(string[] args)
		{
			int _age,_amount;
			Console.WriteLine("Enter age");
			_age=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter amount ");
			_amount=Convert.ToInt32(Console.ReadLine());
			if (_age>=18&& _amount>=10000) 
			{
				Console.WriteLine("ELigible");
			}
			else
				Console.WriteLine("Not Eligible");
			Console.ReadKey(true);
		}
	}
}
