using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
     class SepetManager
    {
        // manager yazıyorsa bir operasyon tutuyor demek.
        //syntax
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : "+ urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int urunAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : "+ urunAdi);
        }
    }
}
