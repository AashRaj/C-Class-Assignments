using System;

namespace FibonacciFirst7
{
	class Program
	{	
		public static void Main(string[] args)
		{
			int var1=0,var2=1,var3;
				for (int i = 1; i <=7; i++) 
				{
					var3=var1+var2;
					Console.WriteLine(var3);
					var1=var2;
					var2=var3;
				}
			Console.ReadKey(true);
		}
  }
}
