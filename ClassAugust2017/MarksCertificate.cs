using System;

namespace MarksCertificate
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Variable Declaration
			
			string _name,_course,_address,_subject1,_subject2,_subject3;
			int _age,_marks1,_marks2,_marks3,_ave;
			
			//Inputs from USERS
			
			//Name
			Console.WriteLine("Enter Name");
			_name=Console.ReadLine();
			//Age
			Console.WriteLine("Enter Age");
			_age=Convert.ToInt32(Console.ReadLine());
			//Course
			Console.WriteLine("Enter Course");
			_course=Console.ReadLine();
			//Address
			Console.WriteLine("Enter Address");
			_address=Console.ReadLine();
			//Sub1
			Console.WriteLine("Enter Subject1");
			_subject1=Console.ReadLine();
			//Sub2
			Console.WriteLine("Enter Subject2");
			_subject2=Console.ReadLine();
			//Sub3
			Console.WriteLine("Enter subject3");
			_subject3=Console.ReadLine();	
			//Marks1
			Console.WriteLine("Enter marks1");
			_marks1=Convert.ToInt32(Console.ReadLine());
			//Marks2
			Console.WriteLine("Enter marks2");
			_marks2=Convert.ToInt32(Console.ReadLine());
			//Marks3
			Console.WriteLine("Enter marks3");
			_marks3=Convert.ToInt32(Console.ReadLine());
			_ave=(_marks1+_marks2+_marks3)/3;
			
			//--------Output----------
			
			Console.WriteLine("--------CERTIFICATE--------");
			Console.WriteLine("Name = "+_name);
			Console.WriteLine("Course = "+_course);
			Console.WriteLine("Age = "+_age);
			Console.WriteLine("Address = "+_address);
			Console.WriteLine("Subject 1 = "+_subject1);
			Console.WriteLine("Subject 2 = "+_subject2);
			Console.WriteLine("Subject 3 = "+_subject3);
			Console.WriteLine("Marks 1 = "+_marks1);
			Console.WriteLine("Marks 2 = "+_marks2);
			Console.WriteLine("Marks 3 = "+_marks3);
			Console.WriteLine("Average marks = "+_ave);
			Console.WriteLine("===========================");
			Console.ReadKey(true);
		}
	}
}
