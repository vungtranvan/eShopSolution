using eShopSolution.ViewModels.Utilities.Slider;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public interface ISliderApiClient
    {
        Task<List<SliderVm>> GetAll();
    }
}
