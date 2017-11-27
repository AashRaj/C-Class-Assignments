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
			for(int i=1;i<=7;i++)
			{
				for (int j = 1; j <= 7; j++) 
				{
					if (i+j==5 || i+j==11 || (i+j==9 &&i!=7 &&j!=7) || (i+j==7 &&i!=6 &&j!=6) ) 
					{
						Console.Write("*");
					}
					else
						Console.Write(" ");
				}
				Console.WriteLine();
			}
			Console.ReadKey(true);
		}
	}
}
