using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Managerler operasyon tutan sınıflardır.
namespace Metotlar
{
     class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine($"Tebrikler. Sepete eklendi : {urun.Adi}");
        }

        public void Ekle2()
        {
            
        }
    }
}