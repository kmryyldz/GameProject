using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamerService
    {
        void Add(gamer gamer);
        void Update(gamer gamer);
        void Delete(gamer gamer);
    }
}
