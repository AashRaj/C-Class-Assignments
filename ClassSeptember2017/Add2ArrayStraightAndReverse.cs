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
			int[] array0={0,1,2,3,4};
			int[] array1={5,6,7,8,9};
			int[] array2=new int[5];
			
			for (int i = 0; i <=4; i++) 
			{
				array2[i]=array0[i]+array1[4-i];
			}
			for (int i = 0; i <=4; i++) 
			{
				Console.Write(array2[i]);
			}
			Console.WriteLine();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
