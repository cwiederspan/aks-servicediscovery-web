using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

using Aks.Services.Web.Models;

namespace Aks.Services.Web.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase {

        private readonly ILogger<DataController> Logger;
        private readonly string Identifier;
        private readonly string ChildUrl;

        public DataController(
            ILogger<DataController> logger,
            IConfiguration configuration
        ) {

            this.Logger = logger;
            this.Identifier = configuration.GetValue<string>("Identifier");
            this.ChildUrl = configuration.GetValue<string>("ChildUrl");
        }

        [HttpGet]
        public async Task<Data> GetAsync() {

            Data child = null;

            if (String.IsNullOrEmpty(this.ChildUrl) == false) {
                var client = new System.Net.Http.HttpClient();
                var childValue = await client.GetStringAsync(this.ChildUrl);
                child = new Data(childValue);
            }

            var result = new Data(this.Identifier, child);

            return result;
        }
    }
}
