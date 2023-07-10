using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C36FactoryPatternDemo;
internal interface IOrderable
{
    public double Price { get; set; }
    public int TableNumber { get; set; }
    public bool HereOrToGo { get; set; }
    public void CallingOutOrder(); //use GetDescription() instead
}
