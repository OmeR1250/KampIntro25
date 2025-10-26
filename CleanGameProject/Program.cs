

namespace CleanGameProject;

public class Program
{
    public static void Main(string[] args)
    {
        GamerManager gamerManager = new GamerManager(new UserValidationManager());
        gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "Ömer Mert", LastName = "Armağan", IdentityNumber = 12345 });

        OrderManager orderManager = new OrderManager();
        orderManager.CreateOrder(50);
    }
}