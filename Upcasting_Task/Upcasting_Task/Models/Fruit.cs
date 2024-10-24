using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Task.Models
{
    internal abstract class Fruit
    {
        public decimal Price { get; set; }
        public string Sort { get; set; }
        protected Fruit(decimal price, string sort)
        {
            Price = price;
            Sort = sort;
        }
        public virtual void Taste()
        {
            Console.WriteLine("Sour");
        
        }
    }
}
