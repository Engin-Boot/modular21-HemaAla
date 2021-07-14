using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{     class OperationsWithColorCode
	{
		public static ColorPair GetColorFromPairNumber(int pairNumber)
		{
			int minorSize = EvenCountColorCode.colorMapMinor.Length;
			int majorSize = EvenCountColorCode.colorMapMajor.Length;
			if (pairNumber < 1 || pairNumber > minorSize * majorSize)
			{
				throw new ArgumentOutOfRangeException(string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
			}
			int zeroBasedPairNumber = pairNumber - 1;
			int majorIndex = zeroBasedPairNumber / minorSize;
			int minorIndex = zeroBasedPairNumber % minorSize;
			ColorPair pair = new ColorPair() { majorColor = EvenCountColorCode.colorMapMajor[majorIndex],minorColor = EvenCountColorCode.colorMapMinor[minorIndex] };
			return pair;
		}
		public static int GetPairNumberFromColor(ColorPair pair)
		{
			int majorIndex = -1;
			int minorIndex = -1;
			int k1=0;
			int k2=0;
			for (int i = 0; i < EvenCountColorCode.colorMapMinor.Length; i++)
			{
				if (EvenCountColorCode.colorMapMajor[i] == pair.majorColor)
				{
					majorIndex = i;
					k1=1;
					//break;
				}

				if (EvenCountColorCode.colorMapMinor[i] == pair.minorColor)
				{
					minorIndex = i;
					k2=1;
				}
			
				if(k1==1 && k2==1)
				{
					break;
				}
				
				
			}

			
			if (majorIndex == -1 || minorIndex == -1)
			{
				throw new ArgumentException(string.Format("Unknown Colors: {0}", pair.ToString()));
			}
			return (majorIndex * EvenCountColorCode.colorMapMinor.Length) + (minorIndex + 1);
	
}
}
}
			
		
		
