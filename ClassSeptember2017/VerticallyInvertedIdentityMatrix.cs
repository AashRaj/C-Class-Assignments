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
			int[,] matrix1 =new int[4,4];
			
			for (int i = 0; i <=3; i++) 
			{
				for (int j = 0; j <=3; j++) 
				{
					if(j==(3-i))
						matrix1[i,j]=1;
					else
						matrix1[i,j]=0;
				}
			}
				
			for (int i = 0; i <=3; i++)
			{
				for (int j = 0; j <=3; j++) 
				{
					Console.Write(matrix1[i,j]);
				}
				Console.WriteLine();
			
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
