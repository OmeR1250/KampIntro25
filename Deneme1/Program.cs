namespace Deneme1;

public class Program
{
    public static void Main(string[] args)
    {

        IRaceService rallyRaceManager = new RallyRaceManager();
        IRaceService dragRaceManager = new DragRaceManager();
        IRaceService trackRaceManager = new TrackRaceManager();

        VehicleManager vehicleManager = new VehicleManager(rallyRaceManager);
        vehicleManager.GetUsableVehicles(new List<IRaceService> {rallyRaceManager,
         dragRaceManager , trackRaceManager });

    }
    
}