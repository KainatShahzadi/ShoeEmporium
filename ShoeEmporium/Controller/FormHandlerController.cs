using ShoeEmporium.Models;
using System.IO;
using ShoeEmporium.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace ShoeEmporium.Controllers
{
    [Route("[controller]")]
    public class FormHandlerController : Controller
    {
        JasonProductFile ProductService;
        public FormHandlerController(JasonProductFile productService)
        {
            this.ProductService = productService;
        }
        [HttpGet]
        public string Get(int id, string name, string image)
        {
            Product obj = new Product();
            obj.Product_id = id;
            obj.Product_name = name;
            obj.Product_image = image;



            ProductService.setProductsData(obj, ProductService);
            return "Function Exec";
        }
    }
}