using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Task.Models
{
    internal class Pineapple:Fruit
    {
        public int VitaminE { get; set; }
        public int VitaminD { get; set; }
        public Pineapple(int vitaminE,int vitaiminD,decimal price,string sort):base(price, sort)
        {
            VitaminD = vitaiminD;
            VitaminE = vitaminE;
        }
        public override void Taste()
        {
            base.Taste();
        }
    }
}
