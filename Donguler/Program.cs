            
            
string kurs1 = "A kursu";
string kurs2 = "B kursu";
string kurs3 = "C kursu";

// array - dizi

string[] kurslar = new string[] { "A kursu", "B kursu", "C kursu", "D kursu" };


for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("For bitti");

foreach(string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("sayfa sonu - footer");

