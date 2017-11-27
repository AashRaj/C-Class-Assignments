/*
 * Created by SharpDevelop.
 * User: Aash
 * Date: 22-09-2017
 * Time: 10:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace functionStudentDatabase_2
{
	class Program
	{
		public static string studentName,studentId,studentAddress,subject1,subject2,subject3,mark1,mark2,mark3;
		public static void Main(string[] args)
		{
			studentinput();
			studentoutput();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void studentinput()
		{
			Console.WriteLine("Enter Name");
			studentName=Console.ReadLine();
			Console.WriteLine("Enter Id");
			studentName=Console.ReadLine();
			Console.WriteLine("Enter Name");
			studentAddress=Console.ReadLine();
			Console.WriteLine("Enter subject 1");
			subject1=Console.ReadLine();
			Console.WriteLine("Enter subject 2");
			subject2=Console.ReadLine();
			Console.WriteLine("Enter subject 3");
			subject3=Console.ReadLine();
			Console.WriteLine("Enter mark 1");
			mark1=Console.ReadLine();
			Console.WriteLine("Enter mark 2");
			mark2=Console.ReadLine();
			Console.WriteLine("Enter mark 3");
			mark3=Console.ReadLine();
		}
		public static void studentoutput()
		{
			Console.WriteLine("student name is "+studentName);
			Console.WriteLine("student roll is "+studentId);
			Console.WriteLine("student address is "+studentAddress);
			Console.WriteLine("student subject1 is "+subject1);
			Console.WriteLine("student subject2 is "+subject2);
			Console.WriteLine("student subject3 is "+subject3);
			Console.WriteLine("student mark 1 is "+mark1);
			Console.WriteLine("student mark 2 is "+mark2);
			Console.WriteLine("student mark 3 is "+mark3);
		}
	}
}
