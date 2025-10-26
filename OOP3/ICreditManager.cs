using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP3
{
    //interfaceler newlenemez
    //bir interface bizim için şu şablona uymak zorundasın demek
    //***İnterfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız***
    public interface ICreditManager
    {
        void Calculate();
        void DoSomething();
       
    }
}