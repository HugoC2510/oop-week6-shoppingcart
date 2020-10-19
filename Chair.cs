using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23168_Hugo_Camps_OOP_Week6
{
    class Chair:Product
    {
        double price { get; set; }
        string name;
        public Chair()
        {
            this.name = "Chair";
            this.price = 25;
        }
        public override double Price()
        {
            return this.price;
        }
        public override string Name()
        {
            return this.name;
        }
    }
}
