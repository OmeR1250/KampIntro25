using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP2;

public class Customer
{
    
    //Eğer ki bir nesnede bir değer o nesneye ait değilmiş gibi duruyorsa
    // orada bir soyutlama hatası yapıyorsun
    public int Id { get; set; }
    public string CustomerNo { get; set; }
}
