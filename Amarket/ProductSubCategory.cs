using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Amarket
{
    public class ProductSubCategory
    {
      
        public Guid Id { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public ProductCategory Category { get; set; }
        public string SubCategoryName { get; set; }
    }
}
