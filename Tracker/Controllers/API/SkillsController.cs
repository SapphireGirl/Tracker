using System.Collections.Generic;
using System.Web.Http;

namespace Tracker.Controllers.API
{
    //, "Never doubt you are valuable and powerful and 
    // deserving of every chance and opportunity in the world to pursue 
    // and achieve your own dreams." HRC
    // Only look back to see how far you have come
    public class SkillsController : ApiController
    {

       
        // GET: api/Skills
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Skills/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Skills
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Skills/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Skills/5
        public void Delete(int id)
        {
        }
    }
}
