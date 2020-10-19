using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23168_Hugo_Camps_OOP_Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> bag = new List<Fruit>();
            Orange O1 = new Orange();
            Apple A1 = new Apple();
            double cost = 0;
            bag.Add(O1);bag.Add(A1);
            foreach (Fruit item in bag) 
            {
                cost = cost + item.price; 
            } 
            
            Console.WriteLine("the price is "+ cost);
            Console.Read();
        }
    }
}
