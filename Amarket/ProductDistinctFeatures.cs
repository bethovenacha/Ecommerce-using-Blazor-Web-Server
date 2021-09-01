using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Amarket
{
    public class ProductDistinctFeatures
    {       
        public Guid Id { get; set; }
        [ForeignKey("Product")]
        public Guid Product_FK { get; set; }
        public virtual Product Product { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

    }
}
