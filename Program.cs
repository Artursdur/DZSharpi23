using System.Drawing;

namespace DZSHARPICONSOLEAPP3
{
    internal class main
    {
        static void Main(string[] args)
        {
            Tochka point = new Tochka(10, 20, 30);

            point.Print();

            point.MoveBy(1, 5, 25);

            point.Print();

            PC pc = new PC("Asus ROG 12555", 12.22, 32, 1000);
            pc.Info();

            User user = new User("Alex", "Smith", "Peter", 22);
            user.Fio();

            Ofice postOffice = new Ofice(66778839, "NY", "Wall st.", 22, 45, 195, "hello");
            postOffice.Info();

            LapTap msi = new LapTap("MSI Catana", 12.22, 32, 1000, 2000);
            msi.Info();

            Phone iphone11 = new Phone("iphone 11", 7.22, 16, 32, 300, "ios");
            iphone11.Info();

            Pramougol rect = new Pramougol(2, 4, 7, 1);
            rect.Perimeter();
            rect.Square();

            Treugol triangle = new Treugol(10, 10, 10);
            triangle.Perimeter();
            triangle.Square();
            triangle.Info();

            Krug circle = new Krug(2, 4, 5);
            circle.Square();
            circle.Lenght();

            Kvadrat square = new Kvadrat(1, 3, 5);
            square.Perimeter();
            square.Area();
        }
    }
}