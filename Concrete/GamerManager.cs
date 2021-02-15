using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
        class GamerManager : IGamerServices
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu Kayıt Edildi"); 
            }
            else 
            {
                Console.WriteLine("Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Kayıdı Silindi"); 
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Kayıdı Güncellendi");
        }
    }
}
