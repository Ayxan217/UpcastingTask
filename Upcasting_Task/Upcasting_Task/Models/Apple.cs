using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Task.Models
{
    internal class Apple:Fruit
    {
        public int VitaminA {  get; set; }
        public int VitaminB { get; set; }
        public Apple(int vitaminA,int vitaminB, decimal price, string sort):base(price, sort)
        {
            VitaminA = vitaminA;
            VitaminB = vitaminB;
        }
        public override void Taste()
        {
            Console.WriteLine("sweet"); 
        }

    }
}
