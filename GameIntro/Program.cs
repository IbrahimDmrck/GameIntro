using GameIntro.Adapter;
using GameIntro.Concrete;
using GameIntro.Work.Concrete;
using System;

namespace GameIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer
            {
                Id = 1,
                IdentityNumber = 1111111111111,
                FirstName = "İbrahim",
                LastName = "DEMİRCİK",
                BirthYear = 2001

            };
            gamerManager.Add(gamer);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign { CampaignId=1,CampaignName="%20 Güz İndirimi",DiscountRate=0.20M};
            campaignManager.Add(campaign);


            GameManager gameManager = new GameManager();
            Game game = new Game { GameId=1,GameName= " OTHERWORLD " , CategoryName=" Aksiyon,Korku,Gerilim ",GamePrice=150 };//oyun ismini çalmayın sakın  

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer, game);
            salesManager.CampaignSales(game, gamer, campaign);


        }
    }
}
