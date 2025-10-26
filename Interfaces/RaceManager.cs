using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public class RaceManager
    {
        public void Add(IRaceService raceService)
        {
            raceService.Add();
        }
    }
}