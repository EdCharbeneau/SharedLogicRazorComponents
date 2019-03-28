using Microsoft.AspNetCore.Mvc;
using Northwind.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCShell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly INorthwindService nwService;

        public ValuesController(INorthwindService northwindService)
        {
            nwService = northwindService;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await nwService.GetAllEmployeesAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
