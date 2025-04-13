using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZSHARPICONSOLEAPP3
{
    public class Pramougol
    {

        private double x1;
        private double y1;


        private double x2;
        private double y2;

        public Pramougol(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Perimeter()
        {
            double length = Math.Abs(x2 - x1);
            double width = Math.Abs(y2 - y1);

            double perimetr = 2 * (length + width);
            Console.WriteLine($"Perimeter = {perimetr}\n");
        }

        public void Square()
        {
            double length = Math.Abs(x2 - x1);
            double width = Math.Abs(y2 - y1);

            double square = length * width;
            Console.WriteLine($"Square = {square}\n");
        }

    }
}