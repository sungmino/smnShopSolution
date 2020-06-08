﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace smnShopSolution.ViewModels.Catalog.ProductImages
{
    public class ProductImageViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public bool IsDefault { get; set; }
        public string Caption { get; set; }
        public DateTime DateCreated { get; set; }
        public long FileSize { get; set; }
        public int SortOrder { get; set; }
    }
}
