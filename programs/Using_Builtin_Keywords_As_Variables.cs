/*
 * Created by Shahadat Hossain
 * User: ProBook
 * Date: 1/3/2016
 * Time: 7:00 PM
 * 
 */
using System;

namespace Using_Builtin_Keywords_As_Variable.cs
{
	class Root
	{		
		public static void Main(string[] args)
		{
			Console.Clear();
			
			String @foreach = "Some text";
			int @int = 7;
			double @public = 5.0;
			
			Console.WriteLine(" foreach is used as variable: {0}" +
			                  "\n int is used as variable: {1}" +
			                  "\n public is used as variable: {2}", @foreach, @int, @public);
			
			Console.Write("\n\n Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}