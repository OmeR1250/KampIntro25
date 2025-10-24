using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP3
{
    public class ApplyManager
    {   
        //Method injection
        public void CreateApply(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Evaluation of informations
            //
            //-----------------------
            //MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculate();
            //bunu yaptığın için tüm başvuruları mortgage credite bağımlı hale getirdin!
            //------------------------

            creditManager.Calculate();
            loggerService.Log();
            //şu anda bağımlılıktan kurtulduk hangi krediyi gönderirsen 
            // onun calculatesi çalışır. mesela ben vehicle i gönderdim, 
            // burada onun hesaplası çalışacak.
        }

        public void DoCreditPreinformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}