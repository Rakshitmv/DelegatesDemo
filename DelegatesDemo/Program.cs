using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Delegates Program\n");
            Console.WriteLine("Enter 1: Delegates Single\n"+ "Enter 2: Delegates MutliCast\n" + "Enter 3: Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    DelegatesSingle delegatesSingle = new DelegatesSingle();
                    delegatesSingle.Delegates();
                    break;
                case 2:
                    DelegatesMultiCast delegatesMultiCast = new DelegatesMultiCast();
                    delegatesMultiCast.DelegatesMulti();
                    break;
                case 3:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Please Enter correct Option\n");
                    break;

            }
            Console.ReadLine();
                
            
        }

    }
   
}
