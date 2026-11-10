
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static  int Tong(int n)
        {
            if(n==1)
            {
                return 1;
            }
            return n + Tong(n - 1);
           
        }
    }
}
