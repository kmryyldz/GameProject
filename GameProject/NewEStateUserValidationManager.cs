using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewEStateUserValidationManager :IUserValidationService
    {
        public bool Validate(gamer gamer)
        {
            return true;
        }
    }
}
