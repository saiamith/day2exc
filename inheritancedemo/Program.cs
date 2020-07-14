using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancedemo
{
    class Program
    {
        static void Main(string[] args)
        {

            refrigerator refrigerator = new refrigerator();
            refrigerator.SetrefrigeratorData(101, "mx12", "godrej", 50000, "double", "100lit", "red");
            refrigerator.Display();
            Console.ReadLine();
        }
    }
}
