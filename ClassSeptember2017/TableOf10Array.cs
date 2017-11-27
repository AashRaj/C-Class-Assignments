using System;

namespace ArrayPractice1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] _some=new int[7];
			for (int i = 0; i <=6; i++) 
			{
				_some[i]=((i+1)*10);
			}
			for (int i = 0; i <=6; i++) 
			{
				Console.WriteLine(_some[i]);
			}
			Console.ReadKey(true);
		}
	}
}
