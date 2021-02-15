using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSellerManager : IGameSellerServices
    {
        public void Seller(Gamer gamer,Game game)
        {
            Console.WriteLine(game.GameName+"-----"+game.Price+ "-----"+gamer.FirstName+"-----" + gamer.LastName);
        }
    }
}
