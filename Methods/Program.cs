using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayAdd();
            AddWithoutResult(1,2);
            int number1 = 5;
            int number2 = 10;
            int result = AddWithResult(number1, number2);
            Console.WriteLine("Add result : " + result);
            Console.WriteLine("Pi : " + GetPi());
            Console.WriteLine("add result : " + AddWithResult(2, 3));

            double r = SubcractTwoNumbers(10);
            Console.WriteLine(r);
            r = SubcractTwoNumbers(5.5, 1.5);
            Console.WriteLine(r);


            Console.ReadLine();
        }
        

       static void DisplayAdd() // methodlar için kullanılır.metotların ilk harfi büyük yazılır.
        {
            Console.WriteLine("edit");
        }

        static void AddWithoutResult(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Add result : " + result);
        }
        
        static int AddWithResult (int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        static double GetPi()
        {
            return 3.14;
        }

        static int AddWithResult(int n1, int n2 , int n3)
        {
            return n1 + n2 + n3;
        }

        static double SubcractTwoNumbers(double s1, double s2 = 5)
        {
            return s1 - s2;
        }
        
              
    }
        
            
    }

