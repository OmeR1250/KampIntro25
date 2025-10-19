using System.Collections.Generic;

namespace Koleksiyonlar;

class Program
{
    static void Main(string[] args)
    {
        // string[] isimler = new string[] { "Ali", "Ayşe", "Mehmet", "Fatma" };
        // Console.WriteLine(isimler[0]);
        // Console.WriteLine(isimler[1]);
        // Console.WriteLine(isimler[2]);
        // Console.WriteLine(isimler[3]);

        // isimler = new string[5];
        // isimler[4] = "İlker";
        // Console.WriteLine(isimler[4]);
        // Console.WriteLine(isimler[0]);


        List<string> isimler2 = new List<string>() { "Ömer", "Emirhan" };
        Console.WriteLine(isimler2[0]);
        Console.WriteLine(isimler2[1]);
        isimler2.Add("Mirya");
        Console.WriteLine(isimler2[2]);
        Console.WriteLine(isimler2[0]);
        

    }
}