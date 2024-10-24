using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Task.Models
{
    internal class Orange:Fruit
    {
        public int VitaminC {  get; set; }
        public Orange(int vitaminC, decimal price,string sort ):base(price,sort) 
        {
            VitaminC = vitaminC;

        }
        public override void Taste()
        {
            base.Taste();
        }
    }
}
