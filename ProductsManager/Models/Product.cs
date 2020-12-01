using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProductsManager.Models
{
    public class Product
    {
     [Key]
        public int Id { get; set; }

        [Required, StringLength(50), Display(Name = " Product Name")]
        public string Name { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public double Price { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
