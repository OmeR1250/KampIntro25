

namespace OOP3;


class Program
{
    static void Main(string[] args)
    {
        //interfaceler de o interface i implemente eden class ın referans numarasını tutabilir
        //-------------------------------------------------------------
        //Ekrandaki kullanılabilecek krediler
        ICreditManager personalCreditManager = new PersonalCreditManager();
        
        ICreditManager vehicleCreditManager = new VehicleCreditManager();

        ICreditManager mortgageCreditManager = new MortgageCreditManager();

        //---------------------------------------------------------------

        ILoggerService databaseloggerService = new DataBaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();

        ApplyManager applyManager = new ApplyManager();
          applyManager.CreateApply(vehicleCreditManager, fileLoggerService);

        

        List<ICreditManager> credits = new List<ICreditManager>() { personalCreditManager,vehicleCreditManager};

      //  applyManager.DoCreditPreinformation(credits);
    }
}