using System;

namespace ReferansVeDegerTipler;

public class Program
{
    public static void Main(string[] args)
    {
        int sayi1 = 10;
        int sayi2 = 23;

        sayi1 = sayi2;
        sayi2 = 35;

        Console.WriteLine($"Sayı 1 i değeri {sayi1} ");




        int[] sayilar1 = new int[] { 1, 2, 3 };
        int[] sayilar2 = new int[] { 45, 145, 315 };

        sayilar1 = sayilar2;

        sayilar2[0] = 2648;

        Console.WriteLine($"Sayılar 1 in 0. elemanı {sayilar1[0]}");




        Person person1 = new Person();
        Person person2 = new Person();
        person1.FirstName = "OMERT";

        person2 = person1;
        person1.FirstName = "Zekirgan";

        Console.WriteLine(person2.FirstName);

        Customer customer1 = new Customer();
        customer1.CreditCardNumber = "23232541561";
        Employee employee1 = new Employee();

        person1 = customer1;

        customer1.FirstName = "Şerro";

        Console.WriteLine($"{person1.FirstName}\n{person2.FirstName}");

        Person person3 = customer1;
        customer1.FirstName = "Komik mi";


        Console.WriteLine(((Customer)person3).CreditCardNumber);






    }
}