using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Amarket
{
    public class ProductCategory
    {    
        [Key]
        public Guid Id { get; set; }
       
        public Product Product { get; set; }
        public string CategoryName { get; set; }
       public ICollection<ProductSubCategory> ProductSubCategories { get; set; }
    }
}
