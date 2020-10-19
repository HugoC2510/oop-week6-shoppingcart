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
            Orange O1 = new Orange(); Orange O2 = new Orange();
            Apple A1 = new Apple(); Apple A2 = new Apple();
            double cost = 0;
            bag.Add(O1);bag.Add(A1); bag.Add(A2); bag.Add(O2);
            foreach (Fruit item in bag) 
            {

                if(item is Orange)
                {
                    cost = cost + 0.60;
                    Console.Write("Apple ");
                }
                if (item is Apple)
                {
                    cost = cost + 0.25;
                    Console.Write("Orange ");
                }
       
            }
            Console.WriteLine();
            Console.WriteLine("the price is "+ cost +"E");
            Console.Read();
        }
    }
}
