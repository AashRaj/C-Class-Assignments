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
			int[] _masterArray={1,2,3,4,5,6,7,8,9,10};
			int[] _evenArray=new int[5];
			int[] _oddArray=new int[5];
			for (int i = 0; i <=9 ; i++) 
			{
				if (_masterArray[i]%2==0) 
				{
					_evenArray[i/2]=_masterArray[i];
					
				}
				else
					_oddArray[i/2]=_masterArray[i];
				
			}
			for (int i = 0; i <=4 ; i++)
				Console.Write(_oddArray[i]+" ");
			Console.WriteLine();
			
			for (int i = 0; i <=4 ; i++)
				Console.Write(_evenArray[i]+" ");
			Console.WriteLine();

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
