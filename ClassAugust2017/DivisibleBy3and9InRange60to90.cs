using System;

namespace DivisibleBy3and9InRange60to90
{
	class Program
	{	
		public static void Main(string[] args)
		{
			for (int i = 60; i <= 90;i++) 
			{
				if (i%3==0&&i%9==0)
				{
					Console.WriteLine(i+" Divisible by 9 and 3");
				}
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
