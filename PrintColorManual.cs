using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
	class PrintColorManual
	{
		public static void PrintManual()
		{
			for(int i=1; i<25; i++)
			{
			/// this code will iterate for 25 combinations and prints pair number and pair of colors
			ColorPair testPair1 = OperationsWithColorCode.GetColorFromPairNumber(i);
			Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", i, testPair1);
			}
		}
	}
}
