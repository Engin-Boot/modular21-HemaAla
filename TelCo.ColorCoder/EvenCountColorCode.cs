using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
	//The 25-pair color code, originally known as even-count color code.
	class EvenCountColorCode
	{
		public static Color[] colorMapMajor;
		public static Color[] colorMapMinor;

	
		static EvenCountColorCode()
		{
			colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
			colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
		}
	}

}
