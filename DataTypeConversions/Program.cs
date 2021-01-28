using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 5;
            int s2 = 2;                       // 1. yöntem int tam sayıya yuvarlar.
            int r = s1 / s2;
            Console.WriteLine(r);

            double s11 = 5;
            double s22 = 2;                   // 2. yöntem virgüllü sayı verir
            double rr = s11 / s22;
            Console.WriteLine(rr);

            double s111 = 5;
            int s222 = 2;
            double rrr = s111 / s222;
            Console.WriteLine(rrr);

            Console.WriteLine(Convert.ToInt32(2.6));
            Console.ReadLine();

        }
    }
}
