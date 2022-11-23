using ShoeEmporium.Models;
using ShoeEmporium.Services;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeEmporium.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductRecordController : ControllerBase
    {
        JasonProductFile ProductService;
        public ProductRecordController(JasonProductFile productService)
        {
            this.ProductService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.getProductsData();

        }
    }
}