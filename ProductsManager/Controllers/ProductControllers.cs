using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsManager.Services;
using ProductsManager.Models;

namespace Practice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController(JsonFileProductServices productService)
        {
            this.ProductSevice = productService;
        }

        public JsonFileProductServices ProductSevice { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductSevice.GetProducts();
        }

    }
}