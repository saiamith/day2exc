using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancedemo
{
    class product
    {
        int productId;

        string model;
        string brand;
        int price;

        internal void SetProductData(int productId, string model, string brand, int price)
        {
            this.productId = productId;
            this.model = model;
            this.brand = brand;
            this.price = price;
        }

        internal void Display()
        {

            Console.WriteLine($"ID : {productId} Brand : {brand} Model : {model} Price : Rs.{price}");
        }
    }
}
