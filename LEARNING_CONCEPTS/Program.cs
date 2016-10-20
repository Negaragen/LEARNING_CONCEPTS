using System;

namespace LEARNING_CSHARP
{
	class Program
	{
		static void Main(string[] args)
		{
			// **********
			//int X;
			//int Y;

			//Y = X + 10;
			// **********

			// **********
			//int X;
			//X = 10;
			// **********

			// **********
			//int X = 10;
			// **********

			// **********
			//int X = 10;
			//int Y = X + 5;
			// **********

			// **********
			//int X = 10;

			//X = X + 5;

			//X += 5;
			// **********

			// **********
			//int X = 10;

			//X = X + 1;
			//X += 1;
			//X++;
			//++X;
			// **********

			// **********
			//int X = 10;

			//int Y = X++; // Y = 10, X = 11
			//int Z = ++X; // X = 11, Z = 11
			// **********

			// **********
			//int X = 10;

			//X = X - 1;
			//X -= 1;
			//X--;
			//--X;
			// **********

			// **********
			// byte, int, long, short, uint, ulong, single, double, decimal, char, bool, ...
			// **********

			// **********
			// هر متغیری از هر جنسی را می توان در داخل متغیری از همان جنس قرار داد
			// اعم این که آن جنس را ما بشناسیم یا نشناسیم

			//int X = 10;
			//int Y = 20;

			//X = Y;
			//Y = X;

			//Baghali X;
			//Baghali Y;

			//X = Y;
			//Y = X;

			// ولی هرگاه بخواهیم متغیری از یک جنس را در داخل متغیری از جنس دیگری
			// قرار دهیم، سه حالت امکانپذیر است

			// 1. می توان با خیال راحت
			// 2. می توان به شرط آنکه مسوولیت آن را بپذیریم
			// 3. مطلقا نمی شود

			// 1
			//int X = 10;
			//long Y = 20;

			//Y = X; // Implicit Casting!

			// 2

			//X = (int)Y; // Explicit Casting!

			// 3

			//string S;
			//int X = 20;

			//S = X.ToString();

			//string S = "123";
			//int X = System.Convert.ToInt32(S);
			// **********

			// ==		!=		<		>		<=		>=

			//int X = 1;

			//if (X == 1)
			//{
			//	System.Console.WriteLine("Dad!");
			//}

			//while (X == 1)
			//{
			//	System.Console.WriteLine("Dad!");
			//}

			//if (X == 1)
			//{
			//	System.Console.WriteLine("Dad!");
			//}
			//else
			//{
			//	System.Console.WriteLine("Bidad!");
			//}

			//int intFirstNumber; // Pascal Case

			//int intIndex = 1;

			//while (intIndex <= 10)
			//{
			//	// Do Something(s)

			//	intIndex++;
			//}

			int intIndex = 1;

			while (intIndex <= 10)
			{
				Console.WriteLine("Hello, World!");

				intIndex++;
			}

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
