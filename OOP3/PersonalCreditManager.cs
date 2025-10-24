using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP3
{
    public class PersonalCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal credit payment plan has been calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}