using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierQueuingP2
{

    internal class CashierClass
    {

        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;
        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = "P - " + x.ToString();
            return CashierNumber;
        }
    }
}
