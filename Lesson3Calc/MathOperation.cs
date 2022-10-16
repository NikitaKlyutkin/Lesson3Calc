using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3Calc
{
    internal class MathOperation
    {
        public double SumOper(double number1, double number2)
        {
            return number1 + number2; 
        }
        public double DifOper(double number1, double number2)
        {
            return number1 - number2;
        }
        public double MultOper(double number1, double number2)
        {
            return number1 * number2;
        }
        public double DivOper(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
