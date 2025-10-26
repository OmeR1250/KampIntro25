using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme1
{
    public class VehicleManager(IRaceService raceService)
    {
        public void GetUsableVehicles(List<IRaceService> vehicles)
        {
            foreach( var vehicle in vehicles)
            {
                vehicle.CheckUsableVehicles();
                raceService.CheckUsableVehicles();
            }
        }
    }
}