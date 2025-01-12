using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Square : BaseGeometricShape
    {
        public override double Area()
        {
            if(Height == 0) { 
            return Width * Width;
            }
            else
                return Height * Height;
        }
        //Kare alanını console ekranına yazan metot.
        public void ShowSquare()
        {
            Console.WriteLine($"Karenin Alanı: {Area()}");
        }
    }
}