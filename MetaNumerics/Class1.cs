using System;
using System.Linq;
using Meta.Numerics;
using Meta.Numerics.Matrices;
using Meta.Numerics.Statistics;
using Meta.Numerics.Statistics.Distributions;
using System.Collections;
using System.Collections.Generic;

namespace LeakDetection
{

    public class LeakDetectionOperations
    {

        private int correlationRange;
        private bool leakDetected;

        Queue<float> ch4Que;
        Queue<float> c2h6Que;

        public LeakDetectionOperations(int co = 24)
        {

            Console.WriteLine("Leak Detection Operations Constructor");
        }

        public int leakCheck(float time, float ch4, float c2h6, float latitude, float longitude)
        {

            Console.WriteLine("\n\tLeak Check");

            double result = ComplexMath.Abs(10);

            return 1;
        }
    }
}