/*
 * Created by SharpDevelop.
 * User: Aash
 * Date: 18-09-2017
 * Time: 11:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace functionStudentDatabase
{
	class Program
	{
		public static string[,] StudentDatabase=new string[10,12];
		public static void Main(string[] args)
		{
			string readOrWrite,wannaContinue="h";
			byte studentNumber;
			do
			{
				
				//determining read or write + student number
			
			    Console.WriteLine("Please Enter-- \n READ to read data\n WRITE to write data");
			    readOrWrite=Console.ReadLine();
			    Console.WriteLine("Enter Student Number");
			    studentNumber=Convert.ToByte(Console.ReadLine());
			
			    //starting read or write operation
			    if (readOrWrite=="READ") 
			    {
			    	ReadDatabase(studentNumber);
			    }
			
			    if (readOrWrite=="WRITE")
			    {
			    	WriteDatabase(studentNumber);
			    }
			    Console.WriteLine("\nDo you want to continue\nType YES to continue\nType NO otherwise");
			    wannaContinue=Console.ReadLine();
			}while (wannaContinue=="YES"); 
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void WriteDatabase(byte a)
		{
			Console.WriteLine("STUDENT "+a);
			Console.WriteLine("Enter Name");
			StudentDatabase[a,0]=Console.ReadLine();
			Console.WriteLine("Enter Roll");
			StudentDatabase[a,1]=Console.ReadLine();
			Console.WriteLine("Enter Address");
			StudentDatabase[a,2]=Console.ReadLine();
			Console.WriteLine("Enter Subject 1");
			StudentDatabase[a,3]=Console.ReadLine();
			Console.WriteLine("Enter Subject 2");
			StudentDatabase[a,4]=Console.ReadLine();
			Console.WriteLine("Enter Subject 3");
			StudentDatabase[a,5]=Console.ReadLine();
			Console.WriteLine("Enter Marks 1");
			StudentDatabase[a,6]=Console.ReadLine();
			Console.WriteLine("Enter Marks 2");
			StudentDatabase[a,7]=Console.ReadLine();
			Console.WriteLine("Enter Marks 3");
			StudentDatabase[a,8]=Console.ReadLine();
			Console.WriteLine("Enter Attendence");
			StudentDatabase[a,9]=Console.ReadLine();
			int AVERAGE=(Convert.ToInt32(StudentDatabase[a,6])+Convert.ToInt32(StudentDatabase[a,7])+Convert.ToInt32(StudentDatabase[a,8]))/3;
			StudentDatabase[a,10]=Convert.ToString(AVERAGE);
			if (AVERAGE>=40)
			{
				StudentDatabase[a,11]="pass";
			}
			else
				StudentDatabase[a,11]="fail";
		}
		public static void ReadDatabase(byte a)
		{
			
			Console.WriteLine("Student Name= "+ StudentDatabase[a,0]);
			
			Console.WriteLine("Student Roll= "+ StudentDatabase[a,1]);
			
			Console.WriteLine("Student Address= "+ StudentDatabase[a,2]);
			
			Console.WriteLine("Student Subject 1= "+ StudentDatabase[a,3]);
			
			Console.WriteLine("Student Subject 2= "+ StudentDatabase[a,4]);
			
			Console.WriteLine("Student Subject 3= "+ StudentDatabase[a,5]);
			
			Console.WriteLine("Student Marks 1= "+ StudentDatabase[a,6]);
			
			Console.WriteLine("Student Marks 2= "+ StudentDatabase[a,7]);
			
			Console.WriteLine("Student Marks 3= "+ StudentDatabase[a,8]);
			
			Console.WriteLine("Student Attendence= "+ StudentDatabase[a,9]);
			
			Console.WriteLine("Student Average= "+ StudentDatabase[a,10]);
			
			Console.WriteLine("Student Pass/Fail= "+ StudentDatabase[a,11]);
		}
	}
}
