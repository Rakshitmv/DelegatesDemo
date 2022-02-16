using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class DelegatesSingle
    {
        delegate void DelegatesOperations(int x, int y);

        public void Delegates()
        {
            DelegatesOperations[] obj ={
                new DelegatesOperations(ArithmeticOperations.Add),
                new DelegatesOperations(ArithmeticOperations.Multiplication)
            };

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](5, 7);
                obj[i](3, 6);
            }
        }
    }
}
