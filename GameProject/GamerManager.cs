using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Registered.");
            }
            else
            {
                Console.WriteLine("Verification failed. Registration failed.");
            }


        }

        public void Delete(gamer gamer)
        {
            Console.WriteLine("The record has been deleted.");
        }

        public void Update(gamer gamer)
        {
            Console.WriteLine("The record has been updated.");
        }
    }
}

