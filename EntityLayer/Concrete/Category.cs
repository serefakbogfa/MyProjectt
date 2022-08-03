﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        
        [Key]
        public int CategoryId { get; set; }

        [StringLength(100)]
        public String CategoryName { get; set; }

        [StringLength(1000)]
        public String CategoryDesciption { get; set; }


        public bool CategorySatuts { get; set; }

        public ICollection<Heading> Headings { get; set; }
    }
}
