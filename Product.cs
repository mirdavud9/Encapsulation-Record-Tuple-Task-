using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation__Record__Tuple_Task_
{
 
public class Product
    {
        public string Id;
        public string BrandName;
        public string Model;
        public decimal Price;
        public decimal Cost;
        public decimal Income;
        public int Count
        {
            get { return count; }
            set { count = value < 0 ? 0 : value; }
        }
        private int count;

        public Product(string brandName, string model, decimal price, decimal cost, int count)
        {
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;
            Id = $"{BrandName.Substring(0, 2)}{Model.Substring(0, 2)}";
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"ID: {Id}, Brand: {BrandName}, Model: {Model}, Price: {Price}, Cost: {Cost}, Count: {Count}, Income: {Income}");
        }

        public void Sale(int quantity)
        {
            if (Count >= quantity)
            {
                Count -= quantity;
                decimal saleIncome = (Price - Cost) * quantity;
                Income += saleIncome;
                Console.WriteLine($"{quantity} qeder satildi. Gelir: {saleIncome}₼");
            }
            else
            {
                Console.WriteLine("Yeteri qeder mehsul yoxdur");
            }
        }
    }

}

