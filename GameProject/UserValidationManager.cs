using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(gamer gamer)
        {
           if (gamer.BirthYear == 1994 && gamer.FirstName == "KMRY" && gamer.LastName =="YLDZ" && gamer.IdentityNumber == 123) 
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
