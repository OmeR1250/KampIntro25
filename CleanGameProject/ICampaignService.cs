using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanGameProject
{
    public interface ICampaignService
    {
        void Add();
        void Delete();
        void Update();
        double ApplyDiscount(double price);
    }
}