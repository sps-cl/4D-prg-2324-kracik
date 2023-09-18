using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Operations
{
    internal class OperationAdd
    {
        public class OpAdd : IOperation
        {
            public int Execute(int x, int y)
            {
                return x + y;
            }
        }
    }
}
