﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
                PrintinchToMeterList(1, 10);
            else
                PrintMeterToInchList(1, 10);
        }

        static void PrintinchToMeterList(int start,int stop)
        {
            for(int inch = start; inch <= stop; inch++)
            {
                double meter = inchConverter.ToMeter(inch);
                Console.WriteLine("{0} inch ={1:0.0000}m", inch, meter);
            }
        }
        static void PrintMeterToInchList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double inch = inchConverter.FromMeter(meter);
                Console.WriteLine("{0} m ={1:0.0000}inch", meter, inch);
            }
        }
    }
}
