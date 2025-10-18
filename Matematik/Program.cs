using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();  
            int sonuc = dortIslem.Topla(5, 6);
            Console.WriteLine(sonuc);
        }
    }
}
