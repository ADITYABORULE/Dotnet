namespace catlog;
using System.Collections.Generic;
using Entities;

public class productService
{
    
    public static List<Product> GetAll()
    {

        List<Product> products=new List<Product>();

        products.Add(new Product{id=3, Title="gerbers",price=12.2});
        products.Add(new Product {id=3, Title="rose", price=123.3});
        products.Add(new Product {id=3, Title="jasmin", price=1234.2});
        products.Add(new Product{id=3, Title="lotus", price=123.3});

        return products;


    
        

    }

    public static string Insert()
    {
        Console.WriteLine("new product inssertion process");
        return "product inserted sucessfully";
    }
}