using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanGameProject
{
    public class CampaignManager : ICampaignService
    {
         private ICampaignService? _currentCampaign; // aktif kampanya

        public void SetCurrentCampaign(ICampaignService campaign)
        {
        _currentCampaign = campaign;
         }
        public void Add()
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public double ApplyDiscount(double price)
        {
            if (_currentCampaign != null)
            return _currentCampaign.ApplyDiscount(price);

        return price; // kampanya yoksa fiyat değişmez
        }

        public void Delete()
        {
             Console.WriteLine("Kampanya silindi");
        }

        public void Update()
        {
             Console.WriteLine("Kampanya güncellendi");
        }
    }
}