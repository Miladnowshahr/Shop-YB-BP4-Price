using Microsoft.AspNetCore.Mvc.Rendering;
using ShopYB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Areas.Admin.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }

        public List<SelectListItem> Category { get; set; }
    }
}
