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

			// **********
			// ==		!=		<		>		<=		>=
			// **********

			// **********
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
			// **********

			// **********
			//int intFirstNumber; // Pascal Case
			// **********

			// **********
			//int intIndex = 1;

			//while (intIndex <= 10)
			//{
			//	// Do Something(s)

			//	intIndex++;
			//}
			// **********

			// **********
			//int intIndex = 1;

			//while (intIndex <= 10)
			//{
			//	Console.WriteLine("Hello, World!");

			//	intIndex++;
			//}
			// **********

			// **********
			//System.Console.Write("How many numbers do you have: ");

			//string strNumberCount =
			//	System.Console.ReadLine();

			//int intNumberCount =
			//	System.Convert.ToInt32(strNumberCount);

			//int intSum = 0;

			//int intIndex = 1;

			//while (intIndex <= intNumberCount)
			//{
			//	System.Console.Write("[" + intIndex + "] -> ");

			//	string strNumber =
			//		System.Console.ReadLine();

			//	int intNumber =
			//		System.Convert.ToInt32(strNumber);

			//	//int intNumber =
			//	//	System.Convert.ToInt32(System.Console.ReadLine());

			//	intSum += intNumber;

			//	intIndex++;
			//}

			//System.Console.WriteLine("The sum of these numbers is " + intSum);
			// **********

			// **********
			//string strInput = System.Console.ReadLine();

			//if (strInput == "1")
			//{
			//	System.Console.WriteLine("10");
			//}
			//else
			//{
			//	if (strInput == "2")
			//	{
			//		System.Console.WriteLine("20");
			//	}
			//	else
			//	{
			//		if (strInput == "3")
			//		{
			//			System.Console.WriteLine("30");
			//		}
			//		else
			//		{
			//			if (strInput == "4")
			//			{
			//				System.Console.WriteLine("40");
			//			}
			//			else
			//			{
			//				if (strInput == "5")
			//				{
			//					System.Console.WriteLine("50");
			//				}
			//				else
			//				{
			//					System.Console.WriteLine("Not a valid input!");
			//				}
			//			}
			//		}
			//	}
			//}
			// **********

			// **********
			//string strInput =
			//	System.Console.ReadLine();

			//switch (strInput)
			//{
			//	case "1":
			//	{
			//		System.Console.WriteLine("10");
			//		break;
			//	}

			//	case "2":
			//	{
			//		System.Console.WriteLine("20");
			//		break;
			//	}

			//	case "3":
			//	{
			//		System.Console.WriteLine("30");
			//		break;
			//	}

			//	case "4":
			//	{
			//		System.Console.WriteLine("40");
			//		break;
			//	}

			//	case "5":
			//	case "6":
			//	case "7":
			//	case "8":
			//	case "9":
			//	{
			//		System.Console.WriteLine("50");
			//		break;
			//	}

			//	default:
			//	{
			//		System.Console.WriteLine("Not a valid input!");
			//		break;
			//	}
			//}
			// **********

			// **********
			//string strInput =
			//	System.Console.ReadLine();

			//switch (strInput)
			//{
			//	case "1":
			//	{
			//		System.Console.WriteLine("Step (1)");

			//		goto case "2";
			//	}

			//	case "2":
			//	{
			//		System.Console.WriteLine("Step (2)");

			//		goto case "3";
			//	}

			//	case "3":
			//	{
			//		System.Console.WriteLine("Step (3)");

			//		goto case "4";
			//	}

			//	case "4":
			//	{
			//		System.Console.WriteLine("Step (4)");
			//		break;
			//	}
			//}
			// **********

			// **********
			//int intNumber = 10;

			//while (intNumber < 5)
			//{
			//	System.Console.WriteLine("Hello, World!");
			//}

			//do
			//{
			//	System.Console.WriteLine("Hello, World!");
			//} while (intNumber < 5); // ; -> is requred!
			// **********

			// **********
			//for (A; B; C)
			//{
			//	D;
			//}

			// A, B, D, C, B, D, C, B, D, C,...
			// **********

			// **********
			//int intIndex = 1;

			//while (intIndex <= 10)
			//{
			//	// Do Something(s)!

			//	intIndex++;
			//}

			//for (int intIndex = 1; intIndex <= 10; intIndex++)
			//{
			//	System.Console.WriteLine("Hello, World!");
			//}
			// **********

			// **********
			// Snippet
			// **********

			// **********
			// هرگاه کامپایلر به دستور
			// break
			// برخورد نماید
			// از آخرین حلقه‌ای که در داخل آن قرار دارد خارج می‌شود

			//int intIndex = 1;

			//while (intIndex <= 10)
			//{
			//	if (intIndex == 3)
			//	{
			//		intIndex = 6;
			//		continue;
			//	}

			//	if (intIndex == 8)
			//	{
			//		break;
			//	}

			//	System.Console.WriteLine(">" + intIndex);

			//	intIndex++;
			//}
			// **********

			// **********
			//int A = 10;
			//int B = 20;
			//int C = 30;

			////string strResult = "A = " + A + ", B = " + B + ", C = " + C;

			////string strResult = string.Format("A = {0}, B = {1}, C = {2}", A, B, C);

			//string strResult = string.Format("A = {1}, B = {0}, C = {1}", A, B, C);

			//System.Console.WriteLine(strResult);
			// **********

			// **********
			//string strFirstName = "Dariush";
			//string strLastName = "Tasdighi";

			//string strFullName =
			//	string.Format("{0} {1}", strFirstName, strLastName);

			//System.Console.WriteLine(strFullName);
			// **********

			// **********
			//string str = "A";
			//char chr = 'A'; // 65
			// **********

			// **********
			//bool blnResult = true;

			//if (blnResult)
			//{
			//}

			//if (blnResult == false)
			//{
			//}
			// **********

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
