using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaaMS.Interfaces;
using RaaMS.Models;

namespace RaaMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RulesController : ControllerBase
    {
        IRuleService _ruleService;
        public RulesController(IRuleService ruleService)
        {
            _ruleService = ruleService;
        }
        // GET: api/Rules
        [HttpGet]
        public async Task<IEnumerable<Rule>> Get()
        {
            var rules = await _ruleService.GetRules();
            return rules;
        }

        // GET: api/Rules/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Rules
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Rules/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
