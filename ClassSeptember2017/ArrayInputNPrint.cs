using System;

namespace ArrayPractice1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] _number=new int[5];
			for (int i = 0; i <=4; i++) 
			{
				Console.WriteLine((i+1)+".ENTER A NUMBER");
				_number[i]=Convert.ToInt32(Console.ReadLine());
			}
			for (int i = 0; i <=4; i++) 
			{
				Console.WriteLine((i+1)+"."+_number[i]);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
