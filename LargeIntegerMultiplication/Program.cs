using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeIntegerMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 5, 4 };
            int[] b = { 3, 2, 1 };
            
            Multiplier.multiply(a, b);
        }
    }
}
