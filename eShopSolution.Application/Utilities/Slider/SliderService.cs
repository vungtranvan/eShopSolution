using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.System.Roles;
using eShopSolution.ViewModels.Utilities.Slider;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Utilities.Slider
{
    public class SliderService : ISliderService
    {
        private readonly EShopDbContext _context;

        public SliderService(EShopDbContext context)
        {
            _context = context;
        }


        public async Task<List<SliderVm>> GetAll()
        {
            var slides = await _context.Sliders.OrderBy(x => x.SortOrder).Select(x => new SliderVm()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Url = x.Url,
                Image = x.Image
            }).ToListAsync();

            return slides;
        }
    }
}
