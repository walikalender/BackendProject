using BasicBackendProject.Business.Concrete;
using BasicBackendProject.Core.Utilities.Results;
using BasicBackendProject.DataAccess.Concrete.EntityFramework;
using BasicBackendProject.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace BasicBackendProject.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            if (productManager.GetProductDetails().IsSuccess == true)
            {
                foreach (var item in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine(item.ProductName + " " + item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(productManager.GetProductDetails().Message);
            }
            
        }
    }
}
