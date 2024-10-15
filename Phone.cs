using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation__Record__Tuple_Task_
{
public class Phone : Product
    {
        public int RAM;
        public string Color;
        public decimal Balance;
        public Phone(string brandName, string model, decimal price, decimal cost, int count, int ram, string color = "Black")
            : base(brandName, model, price, cost, count)
        {
            RAM = ram;
            Color = color;
        }
        public void Call(int seconds)
        {
            decimal callCost = seconds * 0.1m;

            if (Balance >= callCost)
            {
                Balance -= callCost;
                Console.WriteLine($"{seconds} saniye zeng edildi. Balans: {Balance}₼");
            }
            else
            {
                Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur.");
            }
        }

        public void Pay(decimal money)
        {
            Balance += money;
            Console.WriteLine($"Balansa {money}₼ elave edildi. Balansiniz: {Balance}₼");
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"RAM: {RAM} GB, Rəng: {Color}, Balans: {Balance} AZN");
        }
    }

}
