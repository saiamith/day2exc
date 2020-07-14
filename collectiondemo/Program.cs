using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectiondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile M1 = new Mobile();

            MobileCatalog catalog = new MobileCatalog();
            catalog.Add(new mobile(1001, "samsung", "note", 15000, "available in black and blue colors"));
            catalog.Add(new mobile(1002, "one plus", "7pro", 45000, "available in black, red and blue colors"));

            var c = catalog.GetMobile(1002);
            c.Display();

            
        }
    }
}
