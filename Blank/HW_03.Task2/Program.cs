using System;

namespace HW_03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a=default;
            System.Boolean b=default;
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            
            sbyte c = default;
            System.SByte d = default;
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());
            
            byte e = default;
            System.Byte f = default;
            Console.WriteLine(e.GetType());
            Console.WriteLine(f.GetType());

            short g = default;
            System.Int16 h = default;
            Console.WriteLine(g.GetType());
            Console.WriteLine(h.GetType());

            ushort i = default;
            System.UInt16 j = default;
            Console.WriteLine(i.GetType());
            Console.WriteLine(j.GetType());

            int k = default;
            System.Int32 l = default;
            Console.WriteLine(k.GetType());
            Console.WriteLine(l.GetType());
            
            uint m = default;
            System.UInt32 o = default;
            Console.WriteLine(m.GetType());
            Console.WriteLine(o.GetType());

            long z = default;
            System.UInt64 q = default;
            Console.WriteLine(z.GetType());
            Console.WriteLine(q.GetType());

            ulong w = default;
            System.Int64 p = default;
            Console.WriteLine(w.GetType());
            Console.WriteLine(p.GetType());

            char ch = default;
            System.Char chh = default;
            Console.WriteLine(ch.GetType());
            Console.WriteLine(chh.GetType());

            float fl = default;
            System.Single fll = default;
            Console.WriteLine(fl.GetType());
            Console.WriteLine(fll.GetType());

            double db = default;
            System.Double dbb = default;
            Console.WriteLine(db.GetType());
            Console.WriteLine(dbb.GetType());

            decimal dc = default;
            System.Decimal dcc = default;
            Console.WriteLine(dc.GetType());
            Console.WriteLine(dcc.GetType());

            string str = "";
            System.String strr ="";
            Console.WriteLine(str.GetType());
            Console.WriteLine(strr.GetType());
 
            object ob = default;
            System.Object obb = default;
        }
    }
}
