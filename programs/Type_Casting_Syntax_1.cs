/*
 * Created by Shahadat Hossain.
 * User: ProBook
 * Date: 1/3/2016
 * Time: 10:07 PM
 */
using System;

namespace Type_Casting_Syntax_1.cs
{
	class Root
	{
		public static void Main(string[] args)
		{
			Console.Clear();
			
			double x = 5.44;
			Console.WriteLine("Type of the variable x is double: {0}", x);
			Console.WriteLine("Type of the variable x is now int: {0}", (int)x);

			Console.Write("\n\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
