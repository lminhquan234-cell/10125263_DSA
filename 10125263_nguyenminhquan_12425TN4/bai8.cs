using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static double Can(int i, int n)
        {
            if (i == n)
            {
                return Math.Sqrt(n);
            }

            return Math.Sqrt(i + Can(i + 1, n));
        }
    }
}
