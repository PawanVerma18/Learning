using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Product
    {
        public string ProductName;
        public double Price;
        public double StockQuantity;

        public Product(string n,double p,double s)
        {
            StockQuantity = 0;
            ProductName= n;
            Price = p;
            StockQuantity= s;
        }
        
        public void Increase(double quantity)
        {
            if (quantity > 0)
            {
                StockQuantity= StockQuantity + quantity;
                Console.WriteLine($"Quantity {quantity} is increased to StockQuantity!");
            }
            else
            {
                Console.WriteLine("Invalid Quantity!");
            }
        }
        public void Decrease(double quantity)
        {
            if(quantity > 0 && quantity<=StockQuantity)
            {
                StockQuantity= StockQuantity - quantity;
                Console.WriteLine($"Quantity {quantity} is decreased from StockQuantity!");
            }
            else
            {
                Console.WriteLine("Invalid Quantity or Insufficient Stock!");
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name:" + ProductName);
            Console.WriteLine("Price:"+Price);
            Console.WriteLine("Initial StockQuantity:" + StockQuantity);
        }
    }
}
