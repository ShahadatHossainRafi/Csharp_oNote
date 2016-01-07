/*
 * Created by Shahadat Hossain.
 * User: ProBook
 * Date: 1/3/2016
 * Time: 2:44 AM
 * 
 */

using System;

namespace RectangleApp
{
	class GetInput
	{
		public int height, width;
		
		public void FunGetInput()
		{
			Console.Clear();
			Console.Write("Enter Height: ");
			height = Convert.ToInt32(Console.ReadLine());
			Console.Write("\nEnter Width: ");
			width = Convert.ToInt32(Console.ReadLine());
		}
	}
	
	class Calculator
	{
		public int FunCalculator(int arg1, int arg2)
		{
			int area = arg1*arg2;
			return(area);
		}
	}

	class Root
	{
		static void Main(string[] args)
		{
			GetInput InptObj = new GetInput();
			InptObj.FunGetInput();
			
			Calculator CalcObj = new Calculator();
			int area = CalcObj.FunCalculator(InptObj.height, InptObj.width);
			Console.WriteLine("\nThe area of the rectangle is: {0}", area);
			
			Console.ReadKey();
		}
	}
}