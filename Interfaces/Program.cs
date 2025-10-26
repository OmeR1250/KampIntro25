

using Interfaces;

namespace Interface;

public class Program
{
    public static void Main(string[] args)
    {

        IRaceService raceService = new DragRaceManager();
        raceService.Add();


    }
}