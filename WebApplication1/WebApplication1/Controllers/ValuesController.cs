using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Database;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;
        private readonly IDatabase _database;

        public ValuesController(ILogger<ValuesController> logger, IDatabase database)
        {
            _logger = logger;
            _database = database;
        }

        [HttpGet]
        public IEnumerable<Model> Get()
        {
            return _database.Models;
        }

        [HttpPost]
        public IActionResult Add([FromBody] int value)
        {
            _database.Models.Add(new Model() { Value = value });
            _database.SaveChanges();
            return new OkResult();
        }
    }
}
