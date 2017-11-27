using System;

namespace ArrayPractice1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] array3=new int[6];
			int[] array1={1,2,3,4,5,6};
			int[] array2={10,40,60,20,100,90};
			
			for (int i = 0; i <=5 ; i++) 
			{
				array3[i]=array1[i]+array2[i];
			}
			
			for (int i = 0; i <=5 ; i++) 
			{
				Console.WriteLine(array1[i]+"+"+array2[i]+"="+array3[i]);
			}
			Console.ReadKey(true);
		}
	}
}
