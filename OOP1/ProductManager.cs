using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP1;

public class ProductManager
{
    //encapsulation
    public void Add(Product product)
    {
        Console.WriteLine($"Ürün eklendi : {product.ProductName}");
    }


    public void Update(Product product)
    {
        Console.WriteLine($"Ürün güncellendi : {product.ProductName}");
    }


    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }   
    
    public void Topla2(int sayi1, int sayi2)
    {
        Console.WriteLine(sayi1 + sayi2);
    }
}