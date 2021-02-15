using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignServices
    {
        void Add(Campaign campaign,Game game);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
