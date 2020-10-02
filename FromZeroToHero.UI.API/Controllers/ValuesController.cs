using FromZeroToHero.Application.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FromZeroToHero.UI.API.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IPersonService _personService;

        public ValuesController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            var people = _personService.GetAll();

            return people.Select(row => row.FullName);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
