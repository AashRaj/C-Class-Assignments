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
			int[,] matrix1 =new int[2,7];
			
			for (int i = 0; i <=1; i++) 
			{
				for (int j = 0; j <=6; j++) 
				{
					matrix1[i,j]=10;
				}
			}
				
			for (int i = 0; i <=1; i++)
			{
				for (int j = 0; j <=6; j++) 
				{
					Console.Write(matrix1[i,j]+" ");
				}
				Console.WriteLine();
			
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
