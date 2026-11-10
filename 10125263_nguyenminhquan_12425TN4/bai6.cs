using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static int  Ucln(int a, int b )
        {
            if (a% b ==0)
            {
                return  b; 
            }
            return  Ucln(b, a % b);
        }
    }
}
