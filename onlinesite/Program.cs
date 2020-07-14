using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlinesite
{
    class Program
    {
       
            static void Main(string[] args)
            {
                customer C1 = new customer();
                C1.Register(78945, "RAVI", "9123456789", "HOUSE no.09", "ravij", new DateTime(1990, 7, 1), "male");
                C1.Display();
            Console.ReadLine();
            }
    }
}
