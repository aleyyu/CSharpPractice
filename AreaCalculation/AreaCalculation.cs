using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    /*
    Alan Hesaplama
    C# Console uygulaması oluşturarak aşağıdaki gereksinimleri karşılayan uygulamayı yazınız.
    
    İşlem yapılmak istenen geometrik şekli kullanıcıdan alınmalı (Daire, Üçgen, Kare, Dikdörtgen vb..)
    Seçilen şekle göre, kenar bilgilerin kullanıcıdan alınmalı
    Hesaplanmak istenen boyutu kullanıcıdan alınmalı (Çevre, Alan, Hacim vb..)
    Hesap sonucunu anlaşılır şekilde geri döndürmeli. 
     */
    internal class AreaCalculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HESAPLAYICI");
            calculatorMenu();
        }

        static void calculatorMenu()
        {
            int shape = 0;
            while (shape != 5)
            {
                Console.WriteLine("Lütfen işlem yapmak şstediğiniz geometrik şekli seçiniz: " +
                "\n1-) Kare\n2-) Dikdörtgen\n3-) Üçgen\n4-) Daire\n5-) Çıkış");
                shape = Convert.ToInt32(Console.ReadLine());

                switch (shape)
                {
                    case 1: //kare
                        Console.WriteLine("Karenin kenarını cm cinsinden giriniz: ");
                        int kareKenar = Convert.ToInt32(Console.ReadLine());
                        sizeCalculatorMenu(kareKenar);
                        break;
                    case 2: //dikdörtgen
                        Console.WriteLine("Dikdörtgenin uzun kenarını cm cinsinden giriniz: ");
                        int uzunKenar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dikdörtgenin kısa kenarını cm cinsinden giriniz: ");
                        int kisaKenar = Convert.ToInt32(Console.ReadLine());
                        sizeCalculatorMenu(uzunKenar, kisaKenar);
                        break;
                    case 3: //üçgen
                        Console.WriteLine("Üçgenin taban kenarını cm cinsinden giriniz: ");
                        int taban = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Üçgenin 2. kenarını cm cinsinden giriniz: ");
                        int kenar2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Üçgenin 3. kenarını cm cinsinden giriniz: ");
                        int kenar3 = Convert.ToInt32(Console.ReadLine());
                        sizeCalculatorMenu(taban, kenar2, kenar3);
                        break;
                    case 4: //daire
                        Console.WriteLine("Dairenin yarıçapını cm cinsinden giriniz: ");
                        int radius = Convert.ToInt32(Console.ReadLine());
                        sizeCalculatorMenuDaire(radius);
                        break;
                    case 5:
                        Console.WriteLine("İşlem sonlandırıldı...");
                        break;
                }
                
            }
            
        }

        static void sizeCalculatorMenu(int kareKenar)   //kare
        {
            int size = 0;
            while (size != 4)
            {
                Console.WriteLine("Lütfen hesaplamak istediğiniz boyutu seçiniz: " +
                "\n1-) Çevre\n2-) Alan\n3-) Hacim\n4-) Çıkış");
                size = Convert.ToInt32(Console.ReadLine());
                switch (size)
                {
                    case 1: //çevre
                        int perimeter = kareKenar * 4;
                        Console.WriteLine("Karenin çevresi: " + perimeter);
                        break;
                    case 2: //alan
                        int area = (int)Math.Pow(kareKenar, 2);
                        Console.WriteLine("Karenin alanı: " + area);
                        break;
                    case 3: //hacim
                        int volume = (int)Math.Pow(kareKenar, 3);
                        Console.WriteLine("Karenin hacmi: " + volume);
                        break;
                    case 4: 
                        Console.WriteLine("İşlem sonlandırılıyor...");
                        break;
                }
            }
            
        }

        static void sizeCalculatorMenu(int kisaKenar, int uzunKenar)   //dikdörtgen
        {
            int size = 0;
            while (size != 4)
            {
                Console.WriteLine("Lütfen hesaplamak istediğiniz boyutu seçiniz: " +
                "\n1-) Çevre\n2-) Alan\n3-) Hacim\n4-) Çıkış");
                size = Convert.ToInt32(Console.ReadLine());
                switch (size)
                {
                    case 1: //çevre
                        int perimeter = 2 * (kisaKenar + uzunKenar);
                        Console.WriteLine("Dikdörtgenin çevresi: " + perimeter);
                        break;
                    case 2: //alan
                        int area = kisaKenar * uzunKenar;
                        Console.WriteLine("Dikdörtgenin alanı: " + area);
                        break;
                    case 3: //hacim
                        Console.Write("Dikdörtgen prizmanın yüksekliğini giriniz: ");
                        int h = Convert.ToInt32(Console.ReadLine());
                        int volume = kisaKenar * uzunKenar * h;
                        Console.WriteLine("Dikdörtgen prizmanın hacmi: " + volume);
                        break;
                    case 4:
                        Console.WriteLine("İşlem sonlandırılıyor...");
                        break;
                }
            }
            
        }

        static void sizeCalculatorMenu(int taban, int kenar2, int kenar3)   //üçgen
        {
            int size = 0;
            while (size != 4)
            {
                Console.WriteLine("Lütfen hesaplamak istediğiniz boyutu seçiniz: " +
                "\n1-) Çevre\n2-) Alan\n3-) Hacim\n4-) Çıkış");
                size = Convert.ToInt32(Console.ReadLine());
                switch (size)
                {
                    case 1: //çevre
                        int perimeter = taban + kenar2 + kenar3;
                        Console.WriteLine("Dikdörtgenin çevresi: " + perimeter);
                        break;
                    case 2: //alan
                        Console.Write("Üçgenin taban kenarına göre yüksekliğini giriniz: ");
                        int ucgenH = Convert.ToInt32(Console.ReadLine());
                        double area = (taban * ucgenH) / 2;
                        Console.WriteLine("Üçgenin alanı: " + area);
                        break;
                    case 3: //hacim
                        Console.Write("Üçgen prizmanın taban üçgeninin yüksekliğini giriniz: ");
                        int tabanH = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Üçgen prizmanın yüksekliğini giriniz: ");
                        int prizmaH = Convert.ToInt32(Console.ReadLine());

                        double tabanArea = (taban * tabanH) / 2;
                        double volume = tabanArea * prizmaH;
                        Console.WriteLine("Üçgen prizmanın hacmi: " + volume);
                        break;
                    case 4:
                        Console.WriteLine("İşlem sonlandırılıyor...");
                        break;
                }
            }
                
        }

        static void sizeCalculatorMenuDaire(int radius)   //daire
        {
            int size = 0;
            while (size != 4)
            {
                Console.WriteLine("Lütfen hesaplamak istediğiniz boyutu seçiniz: " +
                "\n1-) Çevre\n2-) Alan\n3-) Hacim\n4-) Çıkış");
                size = Convert.ToInt32(Console.ReadLine());
                int pi = 3;
                switch (size)
                {
                    case 1: //çevre
                        int perimeter = 2 * pi * radius;
                        Console.WriteLine("Dairenin çevresi: " + perimeter);
                        break;
                    case 2: //alan
                        double area = (pi * Math.Pow(radius, 2));
                        Console.WriteLine("Dairenin alanı: " + area);
                        break;
                    case 3: //hacim
                        double volume = (4 * (pi * Math.Pow(radius, 3))) / 3;
                        Console.WriteLine("Kürenin hacmi: " + volume);
                        break;
                    case 4:
                        Console.WriteLine("İşlem sonlandırılıyor...");
                        break;
                }
            }
                
        }
    }
}
