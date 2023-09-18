using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_Pattern.Operations;

namespace Strategy_Pattern
{
    internal class CalculatorContext
    {
        private IOperation _operation;

        CalculatorContext(IOperation operation)
        {
            _operation = operation;
        }

        public int executeOperation(int x, int y)
        {
            return this._operation.execute(x, y);
        }
    }
}
