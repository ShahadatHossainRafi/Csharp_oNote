/*
 * Created by Shahadat Hossain
 * User: ProBook
 * Date: 1/2/2016
 * Time: 5:00 PM
 * 
 */
using System;

namespace test.cs
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Get a string
			String str = Convert.ToString(Console.ReadLine());
			Console.WriteLine("{0}", str);	
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}