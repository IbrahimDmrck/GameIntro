using GameIntro.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Work.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
