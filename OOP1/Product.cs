using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP1;

    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }


        //CRUD
        /*public void CreateProduct(Product product)
        {
            // Code to create a new product
        }

        public Product ReadProduct(int id)
        {
            // Code to read a product by id
            return new Product();
        }

        public void UpdateProduct(Product product)
        {
            // Code to update an existing product
        }

        public void DeleteProduct(int id)
        {
            // Code to delete a product by id
        }*/
    }
