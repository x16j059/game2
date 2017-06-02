using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 1;
            int r = 2;
            int a = 0;
           for(int i=1; i<10; i++) {
                a = (l+r);
                Console.WriteLine(l+"+"+r+"="+a);
                l = a;
                r++;
            }
            Console.Read();
            }
            
           
        }

    }


