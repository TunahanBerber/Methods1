using System;

namespace Methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2}; //Array: Bir veri tipinde istedeğin ne kadar data eklersen onu tutan yapı
            
                                             
                                            //veri tipinin adını neden yazıyoruz çünkü c# java gibi diller type safe= tip güvenlidir           
            foreach (Urun urun in urunler)  //urun yazan kısım takma isim anlamlı olsun diye isimlendiriyoruz
            {                               //Urun kısmına var yazsanda oluyor esasında ama bu şekilde daha anlamlı                        
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("-------Metotlar-----------");

            //instance (class örneği oluşturuyoruz şu anda)
            //encapsulation 

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);    //Bunları farklı sayfalarda kullanabilirsin metot yapmanın farklılıkları bunlarıdır 
            sepetManager.Ekle(urun2);    //İlerde kodda değişiklik gerekirse tek bir yerden hepsi değişebilir
            
            sepetManager.Ekle2("Armut", "Yeşil Armut ", 12);
            sepetManager.Ekle2("Elma", "Yeşil Elma ", 6);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu ", 80);
        }
    }
}

//do not repeat yourself - DRY - Clean Code - Best Practice
//Metodlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır