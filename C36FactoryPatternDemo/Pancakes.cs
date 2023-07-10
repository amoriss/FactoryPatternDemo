using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C36FactoryPatternDemo;
internal class Pancakes : IOrderable
{
    public double Price { get; set; } = 10.00;
    public int TableNumber { get; set; }
    public bool HereOrToGo { get; set; } = true;

    public void CallingOutOrder()
    {
        Console.WriteLine("Pancakes are ready!");
        Console.WriteLine($"Your total is ${Price}");
    }
}
