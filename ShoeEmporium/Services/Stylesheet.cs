using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeEmporium.Services
{
    public class Stylesheet
    {
        public IWebHostEnvironment WebHostEnvironment;
        public Stylesheet(IWebHostEnvironment webHostEnvironment)

        {
            WebHostEnvironment = webHostEnvironment;
        }
        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "css", "site.css");
            }
        }
        public string getCSS()
        {
            using (var json_file = File.OpenText(JsonFilePath))
            {
                return json_file.ReadToEnd();
            }
        }
    }
}