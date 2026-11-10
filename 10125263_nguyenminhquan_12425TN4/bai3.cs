using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static int Tong(int k)
        {
            if(k==1)
            {
                return 1;
            }
            return 1 / k + Tong(k - 1);
        }
    }
}
