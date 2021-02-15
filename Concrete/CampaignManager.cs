using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignServices
        

    {

        public void Add(Campaign campaign,Game game)
        {
            Console.WriteLine(campaign.CampaignName+ " Campaign Has Arrived! Don't Miss Opportunities!!!!Discount is : " + campaign.Discount);
            if(campaign.CampaignName=="Summer Sale")
            {
                
                Console.WriteLine("you won a summer sale "+ campaign.Discount); 
            }
           else if (campaign.CampaignName == "Winter Sale")
            {

                Console.WriteLine("you won a winter sale " + campaign.Discount);
            }
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Campaign Has Been Deleted !!!");
        }
        
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Campaign Has Updated! New Discount is : " + campaign.Discount);
        }
    }
}
