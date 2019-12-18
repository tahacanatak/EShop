﻿using EShop.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Web.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<CategoryViewModel> Categories { get; set; }

        public List<Product> Products { get; set; }

        public PaginationInfoViewModel PaginationInfo { get; set; }


    }
}
