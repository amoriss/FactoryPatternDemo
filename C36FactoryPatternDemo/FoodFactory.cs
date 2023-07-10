using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C36FactoryPatternDemo;
internal static class FoodFactory
{


    public static IOrderable OrderFood(string choice)
    {
        switch (choice)
        {
            case "buscuits and gravy":
            case "buscuits":
                return new BuscuitsAndGravy();
            case "over easy eggs":
            case "eggs":
                return new OverEasyEggs();
            case "grits":
                return new Grits();
            case "pancakes":
                return new Pancakes();
            default:
                return new Pancakes();
        }
    }
}
