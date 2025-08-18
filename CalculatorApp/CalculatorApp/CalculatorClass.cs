using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate T Formula<T>(T arg1, T arg2);
namespace CalculatorApp
{

    internal class CalculatorClass
    {

    
        private Formula<double> formulaEvent;
        public event Formula<double> CalculateEvent
        {
            add
            {
                formulaEvent += value;
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                formulaEvent -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }
        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double GetQuotient(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
