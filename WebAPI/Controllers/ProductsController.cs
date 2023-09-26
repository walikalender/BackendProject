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
        // LooselyCoupled : Zayıf bağımlılık
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService; 
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.IsSuccess)
            {
                return Ok(result); 
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
