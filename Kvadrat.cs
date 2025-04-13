using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZSHARPICONSOLEAPP3
{
    public class Kvadrat
    {
        private double x;
        private double y;
        private double side;


        public Kvadrat(double x, double y, double side)
        {
            this.x = x;
            this.y = y;
            this.side = side;
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter of square = {side * 4}\n");
        }

        public void Area()
        {
            Console.WriteLine($"Area of square = {side * side}\n");
        }
    }
}