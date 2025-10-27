using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    public static class ListExtensions
    {
        //this sadece extension methodlarda kullanılır
        //anlamı
        //bu method, List<T> sınıfına aitmiş gibi davran
        //araclar1.GetEach();
        //okur sana ListExtensions.GetEach(araclar1);
        public static void GetEach<T>(this List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        //List<T> sınıfını değiştirmeden ona yeni bir özellik kazandırdık
    }
}