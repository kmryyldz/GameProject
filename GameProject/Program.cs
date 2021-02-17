using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new gamer
            {
                BirthYear = 1994,
                FirstName = "KMRY",
                LastName = "YLDZ",
                IdentityNumber = 123
            });

        }
    }
}

    
    
       






    
        

    
        
    

