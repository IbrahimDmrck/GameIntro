using GameIntro.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Work.Abstract
{
    interface ISalesService
    {
        void Sales(Gamer gamer, Game game);
        void CampaignSales(Game game, Gamer gamer, Campaign campaign);
    }
}
