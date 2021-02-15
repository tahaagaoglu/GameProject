using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.IndentityNumber ==111 && gamer.Id==01 && gamer.FirstName=="Taha"&&gamer.LastName=="Ağaoğlu" )
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
