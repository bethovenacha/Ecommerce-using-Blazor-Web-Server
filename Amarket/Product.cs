using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amarket
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
       
        public string Name { get; set; }
       
        public double Quantity { get; set; }  
      
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
      
        public string SKU { get; set; }
      
        public string Barcode { get; set; }
        public string Brand { get; set; }
    
        public Guid ProductStatusId { get; set; }

        public virtual ProductStatus Status { get; set; }
        public Guid ProductCategoryId { get; set; }
        public virtual ProductCategory Category { get; set; }

        public Guid ProductSubCategoryId { get; set; }
        public virtual ProductSubCategory ProductSubCategory { get; set; }

        public virtual ICollection<ProductImage> Image { get; set; }

       
        public Cart Cart { get; set; }
        //public virtual ICollection<ProductVideo> Video { get; set; }  
        //public virtual ICollection<ProductDistinctFeatures> DistinctFeatures { get; set; }


        //public Cart Cart { get; set; }

    }
}
