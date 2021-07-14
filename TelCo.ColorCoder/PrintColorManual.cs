using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
	class PrintColorManual
	{
		public static void PrintManual()
		{
			int major_size=5;
			int minor_size=5;
			int pair_num=0;
			for(int i=0; i<major_size;i++)
			{
				for(int j=0; j<minor_size;j++)
				{
					pair_num=pair_num+1;
					//Console.WriteLine(pairn_num);
					ColorPair testPair1=OperationsWithColorCode.GetColorFromPairNumber(pair_num);
					Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pair_num, testPair1);
					//Console.WriteLine(pair_num);
					//Console.WriteLine(testPair1);
					///testing the print manual is correct or not	
					Debug.Assert(testPair1.majorColor == EvenCountColorCode.colorMapMajor[i]);
					Debug.Assert(testPair1.minorColor == EvenCountColorCode.colorMapMinor[j]);
				}
				
			}
		}
	}
}
