using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_8_2
{
    internal class Triangle:Figure
    {
        public double IAreaFigure(double Base, double Height)
        {
            double Area = (Base * Height) / 2;
            Console.WriteLine($"Площа трикутника: {Area}");
            return Area;
        }
    }
}
