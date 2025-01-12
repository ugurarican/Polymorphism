//Üçgen, Kare ve Dikdörtgen nesnelerimizi oluşturuyoruz.

using Polymorphism;

Triangle triangle = new Triangle();
Rectangle rectangle = new Rectangle();
Square  square = new Square();

//Üçgen nesnemizin yükseklik ve genişlik bilgilerini giriyoruz.
triangle.Width = 10;
triangle.Height = 15;

//Dikdörtgen nesnemizin yükseklik ve genişlik bilgilerini giriyoruz.
rectangle.Width = 5;
rectangle.Height = 20;

//Kare nesnemizin yüksekliği ve genişliği eşit olduğu için sadece bir tanesini giriyoruz.
square.Width = 8;

//Hesaplanan değerleri console ekranında görmek için her nesnenin içinde oluşturduğumuz metotları çağırıyoruz.
triangle.ShowTriangle();
rectangle.ShowRectangle();
square.ShowSquare();