/*
 * Created by SharpDevelop.
 * User: ProBook
 * Date: 1/6/2016
 * Time: 7:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace type_casting_syntax_3.cs
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();
			double x = 5.32;
			Console.WriteLine("Now x = {0}. Hence data type of \"x\" is double.", x);
			Console.WriteLine("\nChanging the data type from double to int...");
			Console.WriteLine("\n\"x\" is now int. So the value is now {0}", Convert.ToInt32(x));
			
			Console.Write("\n\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}