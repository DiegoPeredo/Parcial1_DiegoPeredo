using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Productos.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [StringLength(30,MinimumLength =1,ErrorMessage ="Ingrese entre 1 a 30 caracteres")]
        public string Description { get; set; }
        [Required]
        public float Price { get; set; }
        public DateTime LastBuy { get; set; }
    }
}