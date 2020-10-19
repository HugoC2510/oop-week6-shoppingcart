using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23168_Hugo_Camps_OOP_Week6
{
    class Bananas:Product
    {
        double price { get; set; }
        string name;
        public Bananas()
        {
            this.name = "Bananas";
            this.price = 0.15;
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
