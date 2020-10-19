using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23168_Hugo_Camps_OOP_Week6
{
    class Program
    {
        static int[] SortedBag(List<Product> list)
        {
            int nbApple=0; int nbOrange=0; int nbBananas = 0; int nbChair = 0;
            foreach(Product item in list)
            {
                if(item is Apple)
                {
                    nbApple++;
                }
                if(item is Orange)
                {
                    nbOrange++;
                }
                if(item is Bananas)
                {
                    nbBananas++;
                }
                if(item is Chair)
                {
                    nbChair++;
                }
            }
            int[] tab = new int[4];
            tab[0] = nbApple;tab[1] = nbOrange;tab[2] = nbBananas;tab[3] = nbChair;
            return tab;
        }

        static double Offer(List<Product> itemInReduction,int[]boughtItems)
        {
            double reduction = 0;
            foreach (Product item in itemInReduction)
            {
                if (item is Apple)
                {
                    int nbOffer = boughtItems[0] / 2; reduction += nbOffer * item.Price();
                    Console.WriteLine("Offer On Apples: -" + nbOffer * item.Price()+"E");
                }
                if (item is Orange)
                {
                    int nbOffer = boughtItems[1] / 3; reduction += nbOffer * item.Price();
                    Console.WriteLine("Offer On Oranges: -" + nbOffer * item.Price()+"E");
                }
                if (item is Bananas)
                {

                }
                if (item is Chair)
                {

                }
            }
            
            return reduction;
        }
        static void Main(string[] args)
        {
            List<Product> bag = new List<Product>();
            Orange orange = new Orange(); 
            Apple apple = new Apple(); Apple A2 = new Apple();
            Bananas banana = new Bananas();
            Chair chair = new Chair();
            double cost = 0;
            bag.Add(apple); bag.Add(apple); bag.Add(apple); bag.Add(apple); bag.Add(orange); bag.Add(orange); bag.Add(orange); bag.Add(banana); bag.Add(chair);//bag.Add(A1); bag.Add(A2); bag.Add(O2);
            foreach (Product item in bag) 
            {
                cost = cost + item.Price();
                Console.Write(item.Name() +" ");
                //if(item is Orange)
                //{
                //    cost = cost + 0.60;
                //    Console.Write("Apple ");
                //}
                //if (item is Apple)
                //{
                //    cost = cost + 0.25;
                //    Console.Write("Orange ");
                //}      
            }
            Console.WriteLine();
            Console.WriteLine("the price is "+ cost +"E");
            List<Product> offerOnItem = new List<Product>();
            offerOnItem.Add(orange); offerOnItem.Add(apple);
            cost -= Offer(offerOnItem, SortedBag(bag));
            Console.WriteLine("the price after reduction is " + cost + "E");
            Console.Read();
        }
    }
}
