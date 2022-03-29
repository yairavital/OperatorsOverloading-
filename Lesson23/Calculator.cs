using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson23.Program;

namespace Lesson23
{



    internal class Calculator
    {
       
        public void CalcAnyThing(double x, double y,CalculatorFunction calculatorFunction )
        {
            calculatorFunction.Invoke(x,y);
        }

     
    }
}
