using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static int luythua(int x, int y)
        {
            if (y ==0)
            {
                return 1;
            }
            return x * luythua(x, x - 1);
        }
    }
}
