using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23168_Hugo_Camps_OOP_Week6
{
    public class Product
    {
        public double price { get; set; }
        public string name { get; set; }
        public virtual double Price()
        {
            return this.price;
        }
        public virtual string Name()
        {
            return this.name;
        }

    }
}
