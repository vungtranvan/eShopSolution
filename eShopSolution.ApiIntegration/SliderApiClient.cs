using eShopSolution.ViewModels.Utilities.Slider;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public class SliderApiClient : BaseApiClient, ISliderApiClient
    {
        public SliderApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<SliderVm>> GetAll()
        {
            return await GetListAsync<SliderVm>("/api/slider");
        }
    }
}
