﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //ProductTest();
        //CategoryTest();

    }

    //private static void CategoryTest()
    //{
    //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    //    foreach (var category in categoryManager.GetAll())
    //    {
    //        Console.WriteLine(category.CategoryName);
    //    }
    //}

    //private static void ProductTest()
    //{
    //    ProductManager productManager = new ProductManager(new EfProductDal());

    //    var result = productManager.GetProductDetails().Data;

    //    if (result.Success == true)
    //    {
    //        foreach (var product in result.Data)
    //        {
    //            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine(result.Message);
    //    }

    //    foreach (var product in productManager.GetProductDetails().Data)
    //    {
    //        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    //    }
    //}
}