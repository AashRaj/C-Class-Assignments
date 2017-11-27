using System;

using System;

namespace EvenOdd1to200
{
	class Program
	{	
		public static void Main(string[] args)
		{
			for(int i=1;i<=200;i=i+1)
			{
				if(i%2==0)
					Console.WriteLine(i+" is even");
				else
					Console.WriteLine(i+" is odd");
			}
			Console.ReadKey(true);
		}
  }
}
