using Microsoft.AspNetCore.Hosting;
using ShoeEmporium.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShoeEmporium.Services
{
    public class JasonProductFile
    {
        public JasonProductFile(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json");
            }
        }

        
        public IEnumerable<Product> GetProductsData()
        {
            using (var json_file = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<Product[]>(json_file.ReadToEnd());
            }
        }
        public void SetProductsData(Product obj, JasonProductFile ProductService)
        {
            IEnumerable<Product> ProductRecords = ProductService.GetProductsData();
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
