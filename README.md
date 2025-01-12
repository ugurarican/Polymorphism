# Polymorphism  
### Burada bizden istenilen:  
- Kare, Dikdörtgen, Dik Üçgen nesnelerinden oluşacak bir uygulamada alan hesaplaması yapmak istiyoruz.  
- Yukarıda bahsettiğimiz nesnelerin her birini üretebilmemiz için classlara ihtiyacımız var.  
- Kare  
- Dikdortgen    
- DikUcgen  
-  Classlarımızı ortak bir çatı altında toplayarak BaseGeometrikSekil classından türetebiliriz.  
-  BaseGeometrikSekil için Propertyler -> Genişlik ve Yükseklik  
-  AlanHesapla() metodu tüm geometrik şekillerde bulanacağından Base Class içerisinde tanımlayabiliriz.  
- Burada dikkat etmemiz gereken durum: Kare ve Dikdortgen için Genişlik x Yükseklik şeklinde hesaplanan alanın Dik Üçgen için (Genişlik x Yükseklik ) / 2 olarak hesaplanması.  
- Polymorphism prensibini kullanarak ilgili uygulamayı kodlayınız. Her classtan bir örnek nesne oluşturarak Alan ölçülerini konsol ekranına yazdırınız.

  ### Base Geometrik Şekiller Nesnemizi oluşturuyoruz.  
Burada ortak olan Yükseklik ve Genişlik bilgilerini property ile tanımlıyouz ve getiriyoruz. Yine ortak olan Alan bilgisini de burada bir metod ile yapıyoruz. Virtual keywordünü yerleştirerek override yapılmasına izin veriyoruz.  
Oluşturduğumuz bu sınıfın tek başına kullanılmasını istemediğimiz için de abstract keyword ile soyutlama yapıyoruz.  
![BaseGeometricShape](https://github.com/ugurarican/Polymorphism/blob/master/baseGeometricShape.png)  

### Üçgen Nesnesini oluşturuyoruz.  
Üçgen classımızı Main Class olan BaseGeometricShape classından implemente ediyoruz.  
Base classta oluşturduğumuz Area metodunu burada override keyword ile kullanarak Base classtaki kullanımını eziyoruz. Üçgenimizin alanını Genişlik x Yükseklik / 2 olarak tanımlıyoruz.  
ShowTriangle metodu ile Üçgenin alan hesabını yazdırıyoruz.  
![Triangle](https://github.com/ugurarican/Polymorphism/blob/master/triangle.png)  

### Dikdörtgen Nesnesini Ooluşturuyoruz.
Dikdörtgen classımızı Main Class olan BaseGeometricShape classından implemente ediyoruz.  
Base classta oluşturduğumuz Area metodunu burada override keyword ile kullanarak Base classtaki kullanımını eziyoruz. Dikdörgenin alanını Genişlik x Yükseklik olarak tanımlıyoruz.  
ShowTRectangle metodu ile Dikdörtgenin alan hesabını yazdırıyoruz.  
![Rectangle](https://github.com/ugurarican/Polymorphism/blob/master/rectangle.png)   

### Kare Nesnesini Ooluşturuyoruz.
Kare classımızı Main Class olan BaseGeometricShape classından implemente ediyoruz.  
Base classta oluşturduğumuz Area metodunu burada override keyword ile kullanarak Base classtaki kullanımını eziyoruz. Kare alanını bir kenarın karesi olarak tanımlıyoruz.  
Burada bir kenar yükseklik veya genişlik girilmiş olabilir bu yüzden if bloğu ile kontrol ediyoruz.  
ShowSquare metodu ile Karenin alan hesabını yazdırıyoruz.  
![Square](https://github.com/ugurarican/Polymorphism/blob/master/square.png)   

### Program.cs classımız.  
Burada Üçgen, Dikdörtgen ve Kare nesnelerini oluşturup genişlik ve yükseklik değerlerini giriyoruz.  
Alanalrı göstermesi için yazdığımız metotları çağırıyoruz.  
![Program](https://github.com/ugurarican/Polymorphism/blob/master/program.png)  

### Console Çıktısı  

Programımızın console çıktısı aşağıdaki gibidir.  
![Display](https://github.com/ugurarican/Polymorphism/blob/master/display.png)
