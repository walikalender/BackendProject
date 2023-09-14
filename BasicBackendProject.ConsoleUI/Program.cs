using BasicBackendProject.Business.Concrete;
using BasicBackendProject.DataAccess.Concrete.EntityFramework;
using System;

namespace BasicBackendProject.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName + " "+ item.CategoryName);
            }
        }
    }
}
