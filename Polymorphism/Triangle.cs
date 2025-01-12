using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Triangle : BaseGeometricShape
    {
        public override double Area()
        {
            return Width * Height / 2.0;
        }
    
        //Üçgenin alanını console ekranına yazan metot.
    public void ShowTriangle()
        {
            Console.WriteLine($"Üçgenin Alanı: {Area()}");
        }

    }
}
