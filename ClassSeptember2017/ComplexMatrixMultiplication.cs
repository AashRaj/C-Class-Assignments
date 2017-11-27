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
			int[,] matrix2 =new int[4,4];
			int[,] matrix3 =new int[4,4];
			//calculation
			for (int i = 0; i <=3; i++) 
			{
				for (int j = 0; j <=3; j++) 
				{
					//1
					matrix1[i,j]=i+1;
					//2
					if (j%2!=0) {
						matrix2[i,j]=1;
					}
					else
						matrix2[i,j]=0;
					//3
					matrix3[i,j]=matrix1[i,j]+matrix2[i,j];
					
				}
			}
			//output
			for (int i = 0; i <=3; i++)
			{
				for (int j = 0; j <=3; j++) 
				{
					Console.Write(matrix3[i,j]);
				}
				Console.WriteLine();
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
