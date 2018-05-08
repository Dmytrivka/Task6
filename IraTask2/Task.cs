using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Task
    {
        public static List<Auto> SortByHorsepower(List<Auto> autos)
        {
            return autos.OrderBy(node => node.Horsepowers).ToList();
        }

        public static Auto FindEconominal(List<Auto> autos, double averageSpeed)
        {
            return autos.OrderBy(node => node.FindBreakdownFuel(averageSpeed)).FirstOrDefault();
        }

        public static Auto FindFastestAuto(List<Auto> autos)
        {
            return autos.OrderBy(node => node.MaxSpeed).LastOrDefault();
        }

        public static void Print(List<Auto> autos)
        {
            autos.ForEach(node => Console.WriteLine(node));
        }
    }
}
