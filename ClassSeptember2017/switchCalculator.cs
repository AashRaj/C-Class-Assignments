/*
 * Created by SharpDevelop.
 * User: Aash
 * Date: 18-09-2017
 * Time: 10:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace switchCalculator
{
	class Program
	{
		/*
		//finction declaration
		public int AdditionOfTwo(int _num1,int _int2);
		public int MultiplicationOfTwo(int _num1,int _int2);
		public int DivisionOfTwo(int _num1,int _int2);
		public int SubstractionOfTwo(int _num1,int _int2);
		public int ModuloOfTwo(int _num1,int _int2);
		*/
		//main function
		public static void Main(string[] args)
		{
			//variable declaration
			int _num1,_num2,_result=0;
			Char _operation;string _response;
			do
			{
				//input
				Console.WriteLine("Enter First Number");
				_num1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Second Number");
				_num2=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Desired operation");
				_operation=Convert.ToChar(Console.ReadLine());
				
				//invokingfunction
				switch (_operation)
				{
					case '+' :
						_result=AdditionOfTwo(_num1,_num2);
						break;
					case '*' :
						_result=MultiplicationOfTwo(_num1,_num2);
						break;
					case '/' :
						_result=DivisionOfTwo(_num1,_num2);
						break;
					case '-' :
						_result=SubstractionOfTwo(_num1,_num2);
						break;
					case '%' :
						_result=ModuloOfTwo(_num1,_num2);
						break;
					default :
						Console.WriteLine("wrong Input");
						break;
				}
			
				//output
				Console.WriteLine("Result is "+ _result);
				Console.WriteLine("Wanna continue ? ,type yes else no");
				_response=Console.ReadLine();
			}
			while(_response=="yes");
		}
		// functions
		public static int AdditionOfTwo( int a, int b)
		{
			int c=a+b;
			return c;
		}
		
		public static int MultiplicationOfTwo(int a,int b)
		{
			int c=a*b;
			return c;
		}
		
		public static int DivisionOfTwo(int a,int b)
		{
			int c=a/b;
			return c;
		}
		
		public static int SubstractionOfTwo(int a,int b)
		{
			int c=a-b;
			return c;
		}
		
		
		public static int ModuloOfTwo(int a,int b)
		{
			int c=a%b;
			return c;
		}
		
	}
}
