using System;




static void Main(string[] args)
{
    Kurs kurs1 = new Kurs();
    kurs1.izlenmeOrani = 68;
    kurs1.KursAdi = "c#";
    kurs1.Egitmen = "Engin Demiroğ";

    Kurs kurs2 = new Kurs();
    kurs1.izlenmeOrani = 65;
    kurs1.KursAdi = "c#";
    kurs1.Egitmen = "Nihat Berberoglu";

    Kurs kurs3 = new Kurs();
    kurs2.izlenmeOrani = 45;
    kurs2.KursAdi = "c#";
    kurs2.Egitmen = "Berk Simsek";

    Console.WriteLine(kurs1 + " " + kurs1.Egitmen);
    //Ternary Operatörü
    Console.Write("[1-10] arasında sayı giriniz :");
    int sayi = int.Parse(Console.ReadLine());
    string cevap = "";
    cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
    Console.WriteLine(cevap);

    // Coalescing Kullanımı
    Console.Write("Lütfen yaşınızı giriniz :");
    string yasiniz = Console.ReadLine();
    string sonuc = "";
    //Burada iki operatörü birarada kullanmış olduk 
    //Ternary kullanma amaçımız kullanıcı direkt boş geçerse stringlerde boş değer bir karakter olduğudan
    //Coalescing de bildiğiniz gibi null değer gelirse varsayılan değeri yazdırır.
    sonuc = (yasiniz == "" ? null : yasiniz) ?? "Boş geçildi.";
    Console.WriteLine("Yaşınız :" + sonuc);

}








class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int izlenmeOrani { get; set; }
}
