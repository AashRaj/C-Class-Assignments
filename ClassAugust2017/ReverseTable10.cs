using System;

namespace star
{
	class Program
	{	
		public static void Main(string[] args)
		{
			int i=10;
			while (i>=1) 
			{
				Console.WriteLine(i+"x10="+(i*10));
				i=i-1;
				
			}
			Console.ReadKey(true);
		}
  }
}
