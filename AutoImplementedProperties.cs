using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SaleItem
    {
        public string Name
        { get; set; }

        public decimal Price
        { get; set; }
    }

    class AutoImplimentedProperties
    {
        static void Main(string[] args)
        {
            var item = new SaleItem { Name = "Shoes", Price = 19.95m };
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
        }
    }
}
