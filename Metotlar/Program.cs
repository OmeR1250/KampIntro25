using Metotlar;

class Program
{
    static void Main(string[] args)
    {

        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyat = 15;
        urun1.Aciklama = "Amasya Elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyat = 80;
        urun2.Aciklama = "Diyarbakır Karpuzu";

        Urun urun3 = new Urun();
        urun3.Adi = "Kia Rio";
        urun3.Fiyat = 865000;
        urun3.Aciklama = "2021 Model";  


        Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

        //type safe -- tip güvenli
        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyat);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("-----------------");
        }


        Console.WriteLine("-------Metotlar-------");
        //instance - örnek
        //encapsulation
        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);
        

        sepetManager.Ekle2();


    } 
}
