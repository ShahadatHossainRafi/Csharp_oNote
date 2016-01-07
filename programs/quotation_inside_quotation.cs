/*
 * Created by SharpDevelop.
 * User: ProBook
 * Date: 1/3/2016
 * Time: 7:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace quotation_inside_quotation.cs
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();
			
			Console.WriteLine("A normal line without double quotation.");
			Console.WriteLine("'A line with single quotations.'");
			Console.WriteLine("\"A line with double quotations.\"");
			Console.WriteLine("'''A line with triple quotations'''");
			
			Console.Write("\n\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
