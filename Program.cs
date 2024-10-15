using Encapsulation__Record__Tuple_Task_;
using System;

class Program
{
    static void Main()
    {
        Phone phone = new Phone("Oppo", "Reno 8", 1400, 1000, 10, 8);
        phone.GetInfo();
        phone.Pay(4);  
        phone.Call(80); 
        phone.GetInfo();

        Console.WriteLine(new string('-', 30));

        Notebook notebook = new Notebook("Asud", "Strix", 3200, 2900, 6, "AMD Ryzen 9", "NVIDIA GeForce RTX 3070 Ti", true);
        notebook.GetInfo();
        notebook.Sale(2); 
        notebook.GetInfo(); 
    }
}
