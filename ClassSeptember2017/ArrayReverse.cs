using System;

namespace ArrayPractice1
{
	class Program
	{
		public static void Main(string[] args)
		{
			char[] array1={'A','B','C','D','E','F'};
			for (int i = 0; i <=5; i++) 
			{
				Console.WriteLine(array1[5-i]);
			}
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
