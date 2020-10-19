using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23168_Hugo_Camps_OOP_Week6
{
    public class Apple:Fruit
    {
        double price{ get; set; }
        string name;
        public Apple()
        {
            this.name = "Apple";
            this.price = 0.60;
        }
    }
}
