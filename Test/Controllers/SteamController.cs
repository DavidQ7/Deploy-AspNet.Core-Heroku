using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SteamController : ControllerBase
    {
        private readonly ILogger<SteamController> _logger;
        private readonly ApiService apiService;
        public SteamController(ILogger<SteamController> logger, ApiService apiService)
        {
            _logger = logger;
            this.apiService = apiService;
        }


        [HttpPost]
        public async Task<string> Get(RequestModel requestModel)
        {
            return await apiService.GetFromAPI(requestModel.Link);
        }
    }
}