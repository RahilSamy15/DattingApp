using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DattingAppWEb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DattingAppWEb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext _Context { get; }
        public ValuesController(DataContext context)
        {
            _Context = context;

        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Getvalue()
        {
            var Values =await _Context.Values.ToListAsync(); 
            return Ok(Values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var Value=await _Context.Values.FirstOrDefaultAsync(x => x.id == id );
            return Ok(Value);
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
