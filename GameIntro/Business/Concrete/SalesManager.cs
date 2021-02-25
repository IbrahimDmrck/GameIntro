using GameIntro.Concrete;
using GameIntro.Work.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Work.Concrete
{
    class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            decimal discountedSales = game.GamePrice - (game.GamePrice * campaign.DiscountRate);
            Console.WriteLine(game.GameName + "isimli oyun" + gamer.FirstName + " " + gamer.LastName + 
                "isimli kullanıcıya " + campaign.CampaignName + " kampanyası ile " + discountedSales + " TL "  + " fiyatla satıldı ");

        }

        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun " + gamer.FirstName + " " + gamer.LastName + " isimli kullanıcıya " + game.GamePrice + " TL " + "fiyatla satıldı" );
        }
    }
}
