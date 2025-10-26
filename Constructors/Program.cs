using System;

namespace Constructors;

public class Program
{
    public static void Main(string[] args)
    {
        Customer customer1 = new Customer() { Id = 1, FirstName = "Ömer Mert", LastName = "Armağan", City = "Elazığ" };


        Customer customer2 = new Customer(2,"Emirhan", "Uluksar","İstanbul");


    }
}