using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanGameProject
{
    //MicroService -- yani ben bu GamerManagerin içinde bambaşka bir servis kullanıcam
    //bir manager sınıfın içinde başka bir sınıf kullanacaksan asla onu newleme referanslar sıkıntıya girer
    //onun yerine bunu yap
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {

            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
           Console.WriteLine("Kayıt günlcellendi");
        }
    }
}