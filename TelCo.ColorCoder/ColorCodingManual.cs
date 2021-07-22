using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;


namespace TelCo.ColorCoder
{
    class ColorCodingManual:IManual
    {

        public  void ColorManual()
        {

            int _pairnum = 1;
            for (int i = 0; i < EvenCountColorCode.colorMapMajor.Length; i++)
            {
                for (int j = 0; j < EvenCountColorCode.colorMapMinor.Length; j++)
                {

                    Console.WriteLine("Colors: major{0} - minor{1}, Pair Number: {2}\n", EvenCountColorCode.colorMapMajor[i], EvenCountColorCode.colorMapMinor[j], _painum);
                    _pairnum++;
                }
            }

        }

    }
}
