using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TypeCasting -> Implicit Casting
            
            //Chart to Int
            char a = 'I';
            int b = (char) a;
            Console.WriteLine(b);
            //Console.ReadLine();

            //Char to Long
            char c = 'M';
            long d = (char) c;
            Console.WriteLine(d);
            //Console.ReadLine();

            //Char to Float
            char e = 'R';
            float f = (char) e;
            Console.WriteLine(e);
            //Console.ReadLine();

            //Char to Double
            char g = 'A';
            double h = (char) g;
            Console.WriteLine(h);
            //Console.ReadLine();

            //Int to Long
            int i = 5;
            long j = i;
            Console.WriteLine(j);
            //Console.ReadLine();

            //Int to Float
            int k = 10;
            float l = k;
            Console.WriteLine(l);
            //Console.ReadLine();

            //Int to Double
            int m = 15;
            double n = m;
            Console.WriteLine(n);
            //Console.ReadLine();

            //Long to Float
            long o = 20;
            float p = o;
            Console.WriteLine(p);
            //Console.ReadLine();
            
            //Long to Double
            long q = 25;
            double r = q;
            Console.WriteLine(r);
            //Console.ReadLine();

            //Float to Double
            long s = 30;
            double t = s;
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
