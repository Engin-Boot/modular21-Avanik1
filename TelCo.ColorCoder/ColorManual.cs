using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorManual
    {
        public static void printColorManual()
        {
            int num = 1;
            for(int i=0;i<5;i++){
                for(int j=0;j<5;j++){
                    Console.WriteLine("Pair Number is {0}, Major Color is {1},Minor Color is {2}\n",num, Program.colorMapMajor[i], Program.colorMapMinor[j]);
                    num++;
                }
            }
        }
    }
}
