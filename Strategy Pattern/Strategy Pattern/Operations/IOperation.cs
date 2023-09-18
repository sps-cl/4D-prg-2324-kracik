using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Operations
{
    internal interface IOperation
    {
        int execute(int x, int y);
    }
}
