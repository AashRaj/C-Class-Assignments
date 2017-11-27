using System;

namespace CheckPersonalInfos
{
	class Program
	{	
		public static void Main(string[] args)
		{
			string _name;
			int _salary;
			char _initial;
			Console.WriteLine("CHECK IF NAME IS Albert,INITIAL IS 'R',SALARY IS BETWEEN 10000 AND 5000");
			Console.WriteLine("Enter name");
			_name=Console.ReadLine();
			Console.WriteLine("Enter initial");
			_initial=Convert.ToChar(Console.ReadLine());
			Console.WriteLine("ENTER salary");
			_salary=Convert.ToInt32(Console.ReadLine());
			if (_name=="albert"||_name=="Albert"&&_initial=='R'&&_salary<=10000&&_salary>=5000) 
			{
				Console.WriteLine("Confirmed");
			}
			else
			{
				Console.WriteLine("Not confirmed");	
			}
			Console.ReadKey(true);
		}
  }
}
