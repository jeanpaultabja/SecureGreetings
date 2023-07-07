using Microsoft.AspNetCore.Mvc;
using SecureGreetings.Schemas;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SecureGreetings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecureGreetingsController : ControllerBase
    {
        // GET: api/<SecureGreetingsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SecureGreetingsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SecureGreetingsController>
        [HttpPost]
        public SecureGreetings.Schemas.GreetingsResponse Post(GreetingsRequest msggreetingsrequest)
        {
            GreetingsResponse msggreetingsresponse = new GreetingsResponse();
            msggreetingsresponse.Greetings = "Hello " + msggreetingsrequest.Name;

            return msggreetingsresponse;
        }

        // PUT api/<SecureGreetingsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SecureGreetingsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
