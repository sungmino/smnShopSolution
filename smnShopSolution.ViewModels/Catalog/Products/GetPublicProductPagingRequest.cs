﻿using smnShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace smnShopSolution.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
