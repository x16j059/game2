using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            //整数型
            sbyte vaLueSByte = -100;
            byte valueByte = 100;
            short valudShort = -20000;
            ushort vaLueShort = 50000;
            int vaLueUint =1000000000;
            uint vaLueInt = 4000000000;
            long vaLueLong = -80000000000;
            ulong valueULong = 90000000000;

            //実数型
            float valueFLoat = 3.1415F;
            double valueDouble =3,1415926535;

            //文字方、文字列型
            char vaLueChar = 'A';
           // string valueString=C# PROGRAM;

                //論理型
               // booL walueBooL = true;

            Console.WriteLine("sbyte  : {0}", vaLueSByte);
           // Console.WriteLine("byte  : {0}", vaLueByte);
            Console.WriteLine("short  : {0}", vaLueShort);
           // Console.WriteLine("ushort  : {0}", vaLueUShort);
            Console.WriteLine("int  : {0}", vaLueInt);
            Console.WriteLine("uint  : {0}", vaLueLong);
            Console.WriteLine("Long  : {0}", vaLueLong);
          //  Console.WriteLine("uLong  : {0}", vaLueULong);
          //  Console.WriteLine("fLoat  : {0}", vaLueFLoat);
          //  Console.WriteLine("double  : {0}", vaLueDouble);
            Console.WriteLine("char  : {0}", vaLueChar);
           // Console.WriteLine("string  : {0}", vaLueString);
           // Console.WriteLine("bool  : {0}", vaLueBool);
        }
    }
}
