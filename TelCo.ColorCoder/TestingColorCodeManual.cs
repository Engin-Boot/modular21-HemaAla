using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
	class TestingColorCodeManual : IManual
	{
		
		public static void ColorManual()
	 	{
		    int actaul_pairnum = 1;
		    for (int i = 0; i < EvenCountColorCode.colorMapMajor.Length; ++i)
		    {
		        for (int j = 0; j < EvenCountColorCode.colorMapMinor.Length; ++j)
		        {
		            ColorPair testPair = OperationsWithColorCode.GetColorFromPairNumber(actaul_pairnum);
		            Debug.Assert(testPair.majorColor == Program.colorMapMajor[i]);
		            Debug.Assert(testPair.minorColor == Program.colorMapMinor[j]);

		            testPair = new ColorPair()
		            {
		                majorColor = EvenCountColorCode.colorMapMajor[i],
		                minorColor = EvenCountColorCode.colorMapMinor[j]
		            };
		            int expected_parinum = OperationsWithColorCode.GetPairNumberFromColor(testPair);
		            Debug.Assert(actaul_pairnum == expected_parinum);

		            actaul_pairnum++;
		        }
            	}
      }
	
	}
}
