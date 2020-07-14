using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancedemo
{
    class refrigerator : product
    {
        string door;
        string capacity;
        string colour;
        internal void SetrefrigeratorData(int productId, string model, string brand, int price, string door, string capacity, string colour)
        {
            base.SetProductData(productId, model, brand, price);
            this.door = door;
            this.capacity = capacity;
            this.colour = colour;
        }
        internal void display()
        {
            base.Display();
            Console.WriteLine($"door : {door} capacity : {capacity} colour : {colour}");
        }
    }
}
