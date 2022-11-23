using Microsoft.AspNetCore.Mvc;
using ShoeEmporium.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeEmporium.Controllers
{
    public class GetStyleController : Controller
    {
        Stylesheet StyleService;
        public GetStyleController(Stylesheet styleService)
        {
            this.StyleService = styleService;
        }
        [HttpGet]
        public ContentResult Get()
        {
            return Content(StyleService.getCSS(), "text/css");
        }
    }
}