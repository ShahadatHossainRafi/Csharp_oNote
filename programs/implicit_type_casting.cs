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
			sbyte x = 22;
			Console.WriteLine("SByte \"x\" is {0}", x);
			int y = x;
			Console.WriteLine("\nAfter implicit type casting now int \"y\" is {0}", y);
			
			Console.Write("\n\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}