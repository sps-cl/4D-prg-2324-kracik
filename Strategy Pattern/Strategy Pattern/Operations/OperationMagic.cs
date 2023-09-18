using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Operations
{
    internal class OperationMagic
    {
        public class OpMagic : IOperation
        {
            public int Execute(int x, int y)
            {
                return x * y;
            }
        }
    }
}
