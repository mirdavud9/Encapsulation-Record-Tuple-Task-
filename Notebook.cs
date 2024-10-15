using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation__Record__Tuple_Task_
{
public class Notebook : Product
    {
        public string OpSystem;
        public string Processor;
        public bool HasGraphicCard;

        public Notebook(string brandName, string model, decimal price, decimal cost, int count, string opSystem, string processor, bool hasGraphicCard = false)
            : base(brandName, model, price, cost, count)
        {
            OpSystem = opSystem;
            Processor = processor;
            HasGraphicCard = hasGraphicCard;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Emeliyyat sistemi: {OpSystem}, Processor: {Processor}, Grafik karti: {(HasGraphicCard ? "var" : "yoxdur")}");
        }
    }

}

