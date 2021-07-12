 using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
	/// A class to test the operations mentioned in OperationsWithColorCode.cs
	class Testing
	{
		private static void FormatTheColorCode(){
		
		for(int i=1; i<25; i++)
		{
		/// this code will iterate for 25 combinations and prints pair number and pair of colors
		ColorPair testPair1 = EvenCountColorCode.GetColorFromPairNumber(i);
		Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", i, testPair1);
		
		/// If we don't want to print here, but we want to store in a dictionary and print later

		IDictionary<int, string> numberNames = new Dictionary<int, ColorPair>();
		
		for(int i=1; i<25; i++){
				
			ColorPair testPair1 = EvenCountColorCode.GetColorFromPairNumber(pairNumber);
		
			IDictionary.add(i,testPair1)
		}}
		private static void Main(string[] args)
		{
		    int pairNumber = 4;
		    ColorPair testPair1 = EvenCountColorCode.GetColorFromPairNumber(pairNumber);
		    Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
		    Debug.Assert(testPair1.majorColor == Color.White);
		    Debug.Assert(testPair1.minorColor == Color.Brown);

		    pairNumber = 5;
		    testPair1 = EvenCountColorCode.GetColorFromPairNumber(pairNumber);
		    Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
		    Debug.Assert(testPair1.majorColor == Color.White);
		    Debug.Assert(testPair1.minorColor == Color.SlateGray);

		    ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
		    pairNumber = EvenCountColorCode.GetPairNumberFromColor(testPair2);
		    Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
		    Debug.Assert(pairNumber == 18);

		    testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
		    pairNumber = EvenCountColorCode.GetPairNumberFromColor(testPair2);
		    Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
		    Debug.Assert(pairNumber == 6);		}	}
}
