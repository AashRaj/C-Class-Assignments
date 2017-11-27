using System;

namespace ArrayPractice1
{
	class Program
	{
		public static void Main(string[] args)
		{
			char[] array0=new char[6];
			char[] array1={'A','B','C','D','E','F'};
			for (int i = 0; i <=5; i++)  
			{
				array0[i]=array1[5-i];
			}
			Console.WriteLine("First Array");
			for (int i = 0; i <=5; i++)  
			{
				Console.Write(array0[i]);
			}
			Console.WriteLine();
			Console.WriteLine("Second Array");
			for (int i = 0; i <=5; i++)  
			{
				Console.Write(array1[i]);
			}
			Console.WriteLine();
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
