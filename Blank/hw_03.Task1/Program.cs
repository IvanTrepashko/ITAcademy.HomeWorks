using System;

namespace hw_03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 10;
            int b = 40;
            long c = 10;
            float d = 15.34f;
            double z;
            char ch;
            bool f = true;

            // Implicit conversion

            b = a;
            c = b;
            z = d;
            
            //Explicit conversion

            a = (short)b;
            b = (int)d;
            ch = (char)b;

            //Boxing
       
            Object ob_int, ob_bool, ob_char,ob;
            ob_int = b;
            ob_bool = f;
            ob_char = ch;
            ob = a;

            // Unboxing

            short shor= (short)ob;
            ushort sh =(ushort)(int)ob_int;
            int it = (int)(char)ob_char;
            byte bt = Convert.ToByte((bool)f);
        }   
    }
}
