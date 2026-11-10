using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static int Tong(int x)
        {
            if(x == 1)
            {
                return 1;
            }
            return x * x + Tong(x - 1);

        }
    }
}
