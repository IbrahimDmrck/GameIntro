using GameIntro.Concrete;
using GameIntro.Work.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Work.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" "+ "İsismli kampanya eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "İsismli kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "İsismli kampanya güncellendi.");
        }
    }
}
