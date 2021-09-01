using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Amarket
{
    public class ProductVideo
    {
       [Key]
        public Guid Id { get; set; }
        public virtual Product Product { get; set; }
        public string VideoPath { get; set; }
        public string VideoStatus { get; set; }
        

    }
}
