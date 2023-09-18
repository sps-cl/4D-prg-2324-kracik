using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Operations
{
    internal class OperationMultiply : IOperation
    {
        public int exececute(int x, int y)
        {
            return x * y;
        }
    }
}
