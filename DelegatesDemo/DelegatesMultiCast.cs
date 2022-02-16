using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class DelegatesMultiCast
    {
        delegate void DelegatesOperations(int x, int y);

        public void DelegatesMulti()
        {
            DelegatesOperations obj = ArithmeticOperations.Add;
            obj += ArithmeticOperations.Multiplication;

            obj(3, 5);
            obj(1, 9);
        }
    }
}
