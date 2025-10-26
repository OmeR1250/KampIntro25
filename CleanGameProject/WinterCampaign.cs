using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanGameProject
{
    public class WinterCampaign : ICampaignService
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public double ApplyDiscount(double price)
        {
            return price * 0.50; //%50 indirim
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}