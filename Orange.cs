﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23168_Hugo_Camps_OOP_Week6
{
    public class Orange:Product
    {
        public double price { get; set; }
        public string name { get; set; }
        public Orange()
        {
            this.name = "Orange";
            this.price = 0.25;

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
