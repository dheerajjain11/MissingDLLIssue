using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeakDetection;

namespace MetaNumericsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LeakDetectionOperations ldo = new LeakDetectionOperations();
            ldo.leakCheck(1.1f, 2.1f, 3.1f, 5.1f, 6.1f);
        }
    }
}
