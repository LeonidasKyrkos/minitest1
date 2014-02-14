using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minitest1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))
                {
                    ans += i;                    
                }
            }
        }
    }
}
