using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] students = new string[3]; //arrayler köşeli parantez ile oluşturuluyor...
            students[0] = "çagıl"; // buradaki 0 index...
            students[1] = "leo";
            students[2] = "angel";
            Console.WriteLine("İlk ögrenci : " + students[0]);


            int[] number = new[] { 1, 2, 3, 4 };
            decimal[] decimals = new decimal[5] { 1.1m, 2.2m, 3.3m, 4.4m, 5.5m };
            char[] characters = { 'A', 'B', 'C' };
            Console.WriteLine(characters[0]);
            Console.ReadLine();
            
        }
    }
}
