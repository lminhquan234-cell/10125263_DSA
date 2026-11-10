using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static int demso(int n)
        {
            if(n==0)
            {
                return 0;
            }
            return demso(n / 10) + 1;
        }
    }
}
