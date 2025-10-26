using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameProject
{
    public interface IGamerService
    {
        void Register();
        void Update();
        void Delete();
    }
}