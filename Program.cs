using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { 
                Id = 01,
                FirstName = "Taha", 
                LastName = "Ağaoğlu", 
                BirtYear = "01.01.1999", 
                IndentityNumber = 111 
            });
            GameSellerManager gameSellerManager = new GameSellerManager();
            Game game = new Game();
            game.GameName = "Pes21";
            game.Price = 100;
            gameSellerManager.Seller(new Gamer {
                Id=02,
                FirstName="Cengiz",
                LastName="Karakelle",
                BirtYear="02.02.2000",
                IndentityNumber=222 },game);

           
            Game game2 = new Game();
            game.GameName = "Fifa21";
            game.Price = 200;
            gameSellerManager.Seller(new Gamer
            {
                Id = 03,
                FirstName = "Fatih",
                LastName = "Karakelle",
                BirtYear = "02.02.2000",
                IndentityNumber = 222}, game);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { Id = 01, CampaignName = "Summer Sale", Discount = 25 },game) ;
            Campaign campaign2 = new Campaign
            { Id=02, CampaignName = "Winter Sale", Discount = 30 };
            campaignManager.Add(campaign2,game2);
            campaignManager.Delete(campaign2);

        }
    }
}
