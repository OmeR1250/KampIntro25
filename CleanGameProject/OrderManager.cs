using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanGameProject
{
    public class OrderManager : IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService = null)
        {
            _campaignService = campaignService;
        }

        public void CreateOrder(double price) //game price oluşturmadığım için simüle eidyorum
        {
             if (_campaignService != null)
        {
            price = _campaignService.ApplyDiscount(price);
            Console.WriteLine("Kampanya uygulandı!");
        }

        Console.WriteLine($"Sipariş Oluşturuldu. Fiyat: {price:C2}");
        }
    }
}