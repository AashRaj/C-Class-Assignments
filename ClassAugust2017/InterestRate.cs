using System;

namespace interest
{
	class Program
	{	
		public static void Main(string[] args)
		{
			int _amount;
			_amount=Convert.ToInt32(Console.ReadLine());
			
			switch (_amount) 
			{
				case 10000:
					Console.WriteLine("15%");
					break;
				case 1000000:
					Console.WriteLine("10%");
					break;
				case 1500000:
					Console.WriteLine("8%");
					break;
				case 2000000:
					Console.WriteLine("7.5%");
					break;
				case 2500000:
					Console.WriteLine("7%");
					break;
			}
			Console.ReadKey(true);
		}
  }
}
