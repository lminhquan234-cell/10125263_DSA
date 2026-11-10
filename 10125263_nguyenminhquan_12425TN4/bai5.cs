using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static int ucln(int n)
        {
            if (n% 2 ==1)
            {
                return ucln(n);
            }
            return ucln(n) = ucln(n / 2);
        }    
    }   
}
