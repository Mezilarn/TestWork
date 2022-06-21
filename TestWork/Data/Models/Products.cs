using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWork.Data.Models
{
    public class Products
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Desc { get; set; }
        
        public int Price { get; set; }
    }
}
