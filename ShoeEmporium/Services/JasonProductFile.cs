using ShoeEmporium.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using static ShoeEmporium.Services.JasonProductFile;

namespace ShoeEmporium.Services
{
    public class JasonProductFile
    {

        public IWebHostEnvironment WebHostEnvironment;
        public JasonProductFile(IWebHostEnvironment webHostEnvironment)

        {
            WebHostEnvironment = webHostEnvironment;
        }

        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json");
            }
        }

        public IEnumerable<Product> getProductsData()
        {
            using (var json_file = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<Product[]>(json_file.ReadToEnd());
            }
        }

        public void setProductsData(Product obj, JasonProductFile ProductService)
        {
            IEnumerable<Product> ProductRecords = ProductService.getProductsData();
            List<Product> listProductRecords = ProductRecords.ToList();
            listProductRecords.Add(obj);

            string finalData = JsonSerializer.Serialize<List<Product>>(listProductRecords);
            StreamWriter json_file = new StreamWriter(JsonFilePath);
            json_file.Write(finalData);
            json_file.Flush();
            json_file.Close();
        }

    }
}