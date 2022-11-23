using ShoeEmporium.Models;
using ShoeEmporium.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeEmporium.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Product> Products { get; private set; }
        public JasonProductFile ProductService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            ILogger<IndexModel> logger,
            JasonProductFile productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet()
        {

        }
    }
}