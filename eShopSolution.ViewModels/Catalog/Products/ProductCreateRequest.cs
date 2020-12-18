﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        public decimal Price { get; set; }

        public decimal OriginalPrice { get; set; }

        public int Stock { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        public string Name { set; get; }

        public string Description { set; get; }

        public string Details { set; get; }

        public string SeoDescription { set; get; }

        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }

        public string LanguageId { set; get; }

        public bool? IsFeatured { get; set; }

        public IFormFile ThumbnailImage { get; set; }
    }
}
