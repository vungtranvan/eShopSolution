using eShopSolution.ViewModels.System.Roles;
using eShopSolution.ViewModels.Utilities.Slider;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Utilities.Slider
{
    public interface ISliderService
    {
        Task<List<SliderVm>> GetAll();
    }
}
