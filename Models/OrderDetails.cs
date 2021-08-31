﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onlineshop.Models
{
    public class OrderDetails
    {
        //public int Id { get; set; }
        //[Display(Name ="Order")]
        //public int OrderId { get; set; }
        //[ForeignKey("OrderId")]
        //public Orders Order { get; set; }

        //[Display(Name = "Product")]
        //public int ProductId { get; set; }

        //[ForeignKey("ProductId")]
        //public Products Product { get; set; }



        public int Id { get; set; }
        [Display(Name = "Order")]
        public int OrderId { get; set; }
        [Display(Name = "Product")]
        public int PorductId { get; set; }

        [ForeignKey("OrderId")]
        public Orders Order { get; set; }
        [ForeignKey("PorductId")]
        public Products Product { get; set; }

    }
}