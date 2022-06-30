using System;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
           Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya elması";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.Fiyati = 80;

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach ( Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("-------");
            }
            Console.WriteLine("---------Metotlar------------");

            //instance
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil Armut",12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 6);

        }
    }
}