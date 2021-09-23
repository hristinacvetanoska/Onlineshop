﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Onlineshop.Models
{
    public class Orders
    {
        public Orders()
        {
            OrderDetails = new List<OrderDetails>();
        }
        public int Id { get; set; }
        [Display(Name="Order No")]
        public string OrderNo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name="Phone No")]
        public string PhoneNo { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }


        public virtual List<OrderDetails> OrderDetails { get; set; }
    }
}
