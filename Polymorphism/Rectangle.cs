using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rectangle : BaseGeometricShape
    {
        public override double Area()
        {
            return base.Area();
        }
        //Dikdörtgen alanını console ekranına yazan metot.
        public void ShowRectangle()
        {
            Console.WriteLine($"Dikdörtgenin Alanı: {Area()}");
        }
    }
}
