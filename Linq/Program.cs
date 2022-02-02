using System;
using System.Collections.Generic;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Category> categories = new List<Category>
            {
                new Category{CategoryId =1, CategoryName="Bilgisayar"},
                new Category{CategoryId =2, CategoryName="Telefon"}


            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId =1, ProductName="Acer laptop",QuantityPerUnit="32 Gb Ram",UnitPrice=1000,UnitsInStock=5},
                new Product{ProductId =1, ProductName="Asus laptop",QuantityPerUnit="16 Gb Ram",UnitPrice=8000,UnitsInStock=3},
                new Product{ProductId =1, ProductName="Hp laptop",QuantityPerUnit="8 Gb Ram",UnitPrice=6000,UnitsInStock=2},
                new Product{ProductId =2, ProductName="Samsung Telefon",QuantityPerUnit="4 Gb Ram",UnitPrice=5000,UnitsInStock=15},
                new Product{ProductId =2, ProductName="Apple Telefon",QuantityPerUnit="4 Gb Ram",UnitPrice=8000,UnitsInStock=0},
            };
            Console.WriteLine("Hello World!");
        }
    }

   public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
    }


   public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }

}
