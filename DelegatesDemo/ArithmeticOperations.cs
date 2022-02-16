using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class ArithmeticOperations
    {
        public static void Add(int a, int b)
        {
            System.Console.WriteLine("Addtion of a+b = " + (a + b));
        }
        public static void Multiplication(int a, int b)
        {
            System.Console.WriteLine("Multiplication of a*b  = " + (a * b));
        }
    }
}
