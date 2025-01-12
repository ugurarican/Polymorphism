using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //Bu clas tek başına soyut bir kavram olduğu için abstraction ile soyutluyoruz.
    public abstract class BaseGeometricShape
    {
        //Propertyleri tanımlıyoruz.
        public int Width { get; set; }
        public int Height { get; set; }

       
        //Alanı hesapladığımız metot. Virtual keyword ile override edilmesine izin veriyoruz.
        public virtual double Area()
        {
            return Height * Width;
        }

    }
}
