//soyutlama

namespace OOP2;


class Program
{
    static void Main(string[] args)
{
    //Ömer Mert Armağan
    Individual customer1 = new Individual();
    customer1.Id = 1;
    customer1.CustomerNo = "12345";
    customer1.Name = "Ömer Mert";
    customer1.Surname = "Armağan";

    //Gerçek Müşteri - Tüzel Müşteri
    //Bunlar sırf müşteri diye birbirleriyle karıştırılamazlar
    //SO-L-ID

    Cooporate customer2 = new Cooporate();
    customer2.Id = 2;
    customer2.CustomerNo = "54321";
    customer2.CompanyName = "DigitalHat Yazılım San.Tic.Ltd.Şti.";
    customer2.TaxNo = "2951289092";


    //Customer sınıfı hem gerçek müşteriyi hemde tüzel müşteriyi tutabiliyor referanslarını
    Customer customer3 = new Individual();
    Customer customer4 = new Cooporate();

    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(customer1);
    customerManager.Add(customer2);

}
}