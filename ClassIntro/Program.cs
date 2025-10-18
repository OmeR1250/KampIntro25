
 string adi = "Engin";
    int yas = 36;

    Kurs kurs1= new Kurs();
    kurs1.KursAdi = "C# Geliştirici Kursu";
    kurs1.Egitmen = "Engin Demiroğ";
    kurs1.IzlenmeOrani = 68;

    Kurs kurs2= new Kurs();
    kurs2.KursAdi = "Java Geliştirici Kursu";
    kurs2.Egitmen = "Ömer Mert Armağan";
    kurs2.IzlenmeOrani = 70;
    
    Kurs kurs3= new Kurs();
    kurs3.KursAdi = "Python Geliştirici Kursu";
    kurs3.Egitmen = "Emirhan Uluksar";
    kurs3.IzlenmeOrani = 85;



/*Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
Console.WriteLine(kurs2.KursAdi + " : " + kurs2.Egitmen);
Console.WriteLine(kurs3.KursAdi + " : " + kurs3.Egitmen);*/




Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

foreach (var takmaKurs in kurslar)
{
    Console.WriteLine($"{takmaKurs.KursAdi} : {takmaKurs.Egitmen}");
}



class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}