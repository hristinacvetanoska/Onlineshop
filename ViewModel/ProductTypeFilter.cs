using Microsoft.AspNetCore.Mvc.Rendering;
using Onlineshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onlineshop.ViewModel
{
    public class ProductTypeFilter
    {
        public IList<Products> Product { get; set; }
        public SelectList Types { get; set; }
        public string type { get; set; }
        public string SortBy { get; set; }

    }
}
