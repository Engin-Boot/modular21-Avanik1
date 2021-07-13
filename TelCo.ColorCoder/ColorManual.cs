using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorManual
    {
        public static printColorManual()
        {
            int num = 1;
            for(int i=1;i<=5;i++){
                for(int j=1;j<=5;j++){
                    Console.WriteLine("Pair Number is {0}, Major Color is {1},Minor Color is {2}\n",num, Program.colorMapMajor[i], Program.colorMapMinor[j]);
                    num++;
                }
            }
        }
    }
}
