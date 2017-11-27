/*
 * Created by SharpDevelop.
 * User: Aash
 * Date: 22-09-2017
 * Time: 11:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace functionPassFail
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(result(60,30,40));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static string result(int m1,int m2,int m3)
		{
			if ((m1+m2+m3)>120) {
				return "pass";
			}
			else 
				return "fail";
		}
			
	}
}
