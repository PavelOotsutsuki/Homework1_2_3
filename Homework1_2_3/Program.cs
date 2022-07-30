using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int exitCondition = 100;
            int step=7;

            for (int i=5;i<exitCondition; i+=step)
            {
                Console.Write(i+" ");
            }
        }
    }
}