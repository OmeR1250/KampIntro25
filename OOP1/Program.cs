using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 5000;
product1.UnitsInStock = 3;

Product product2 = new Product
{
    Id = 2,
    CategoryId = 5,
    UnitsInStock = 5,
    ProductName = "Kalem",
    UnitPrice = 35
};
//case sensitive
//PascalCase   //camelCase
//productManager bellekte yeni bir referans numarası tutuyor
//stack                           //heap
ProductManager productManager = new ProductManager();
productManager.Add(product1);
productManager.Add(product2);