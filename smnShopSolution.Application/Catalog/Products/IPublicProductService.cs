using smnShopSolution.Application.Catalog.Products.Dtos;
using smnShopSolution.ViewModels.Catalog.Products;
using smnShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace smnShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);

    }
}
