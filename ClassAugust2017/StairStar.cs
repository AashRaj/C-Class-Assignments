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
			for(int i=0;i<5;i++)
			{
				for(int j=1;j<=i;j++)
					Console.Write("*");
				Console.WriteLine("");
			
			}
			
				
			
			Console.ReadKey(true);
		}
	}
}
