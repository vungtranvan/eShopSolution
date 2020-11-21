using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Dtos;
using eShopSolution.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        private readonly EShopDbContext _context;
        public PublicProductService(EShopDbContext context)
        {
            _context = context;
        }
        public PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
