using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace Aks.Services.Web.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase {

        private readonly ILogger<DataController> Logger;

        private readonly string Identifier;

        public DataController(
            ILogger<DataController> logger,
            IConfiguration configuration
        ) {

            this.Logger = logger;
            this.Identifier = configuration.GetValue<string>("Identifier");
        }

        [HttpGet]
        public IActionResult Get() {

            var result = new {
                Identifier = this.Identifier,
                Timestamp = DateTime.UtcNow.ToString()
            };

            return new JsonResult(result);
        }
    }
}
