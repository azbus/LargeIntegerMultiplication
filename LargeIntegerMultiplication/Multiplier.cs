using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeIntegerMultiplication
{
    class Multiplier
    {
        private Multiplier() { }

        // add Furer algorithm
        public static int[] multiply(int[] a, int[] b)
        {
            int[] result;

            int N;
            if (a.Length < b.Length)
                N = a.Length;
            else
                N = b.Length;

            List<int[]> summands = new List<int[]>();

            for (int i = 0; i < a.Length; i++)
            {
                int[] tempValue = new int[N];
                for (int j = 0; j < b.Length; j++)
                {
                    tempValue[j] += a[i] * b[j];
                }

                summands.Add(tempValue);
            }

            int[] sum = getAmount(summands);
            result = getResult(sum);

            return result;
        }

        private static int[] getAmount(List<int[]> summands)
        {
            int N = summands.Count + summands.ElementAt(0).Length - 1;
            int[] sum = new int[N];

            int j = 0;
            foreach (var summand in summands)
            {
                for (int i = 0; i < summand.Length; i++)
                {
                        sum[i + j] += summand[i];
                }
                j++;
            }

            return sum;
        }
        private static int[] getResult(int[] sum)
        {
            int[] result = new int[1];

            return result;
        }
    }
}
