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
            string valueString=C# PROGRAM;

                //論理型
                booL walueBooL = true;

            Console.WriteLine("{1}  : {0}", vaLueSByte,vaLueSByte.GetType().Name);
            Console.WriteLine("{1}  : {0}", vaLueByte, vaLueByte.GetType().Name);
            Console.WriteLine("{1}  : {0}", vaLueShort, vaLueShort.GetType().Name);
            Console.WriteLine("{1}  : {0}", vaLueUShort, vaLueUShort.GetType().Name);
            Console.WriteLine("{1}  : {0}", vaLueInt, vaLueInt.GetType().Name);
            Console.WriteLine("{1}  : {0}", vaLueLong, vaLueLong.GetType().Name);
            Console.WriteLine("{1}  : {0}", vaLueLong, vaLueLong.GetType().Name);
            Console.WriteLine("{1}  : {0}", vaLueULong, vaLueULong.GetType().Name);
            Console.WriteLine("{1}  : {0}", vaLueFLoat, vaLueFLoat.GetType().Name);
            Console.WriteLine("{1}  : {0}", vaLueDouble, vaLueDouble.GetType().Name);
            Console.WriteLine("{1}  : {0}", vaLueChar, vaLueChar.GetType().Name);
            Console.WriteLine("{1}  : {0}", vaLueString, vaLueString.GetType().Name);
            Console.WriteLine("{1}  : {0}", vaLueBool, vaLueBool.GetType().Name);
        }
    }
}
