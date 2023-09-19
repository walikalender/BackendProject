using BasicBackendProject.Business.Abstract;
using BasicBackendProject.Business.Concrete;
using BasicBackendProject.Core.Utilities.Results;
using BasicBackendProject.DataAccess.Concrete.EntityFramework;
using BasicBackendProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // attribute : class ile ilgili bilgi verme onu imzalama yöntemidir.
    public class ProductsController : ControllerBase
    {
        // LooselyCoupled
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService; 
        }

        [HttpGet]
        public IDataResult<List<Product>> Get()
        {
            return _productService.GetAll();
        }
    }
}
