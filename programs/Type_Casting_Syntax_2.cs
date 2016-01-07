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
//		{
			Console.Clear();
			
			int x = 5;
			Console.WriteLine("Type of the variable x(5) is now string: {0}", x.ToString());
			
			double y = 5.00;
			Console.WriteLine("Type of the variable y(5.00) is now string: {0}", y.ToString());
			
			bool z = true;
			Console.WriteLine("Type of the variable z(true) is now string: {0}", z.ToString());

			Console.Write("\n\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}