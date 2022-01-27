using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    class SepetManager  //Manager, dao, service controller data acces bunlar operasyon tutuyor demektir 
    {
        //naming convention
        //Syntax
        public void Ekle(Urun urun)  //Burada parametre eklendi çünkü metot bir şey ekleyecek ama ne diye sorman lazım progrmamcı olarak
        {
            Console.WriteLine("Tebrikler . Sepete Eklendi :  " + urun.Adi);  
        }

        public void Ekle2(string UrunAdi, string Aciklama, double fiyat)  //Bu yöntem dinamik olmuyor dinamilkiği bozuyor bir ürün ekleme esnasında her yer bozuluyor
        {                                                                               
            Console.WriteLine("Tebrikler . Sepete Eklendi :  " + UrunAdi);
        }
    }
}
