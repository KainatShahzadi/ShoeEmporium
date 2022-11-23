using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShoeEmporium.Models
{
    public class Product
    {
        [JsonPropertyName("id")]
        public int Product_id { get; set; }

        [JsonPropertyName("name")]
        public string Product_name { get; set; }

        [JsonPropertyName("image")]
        public string Product_image { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize<Product>(this);
        }
    }
}
