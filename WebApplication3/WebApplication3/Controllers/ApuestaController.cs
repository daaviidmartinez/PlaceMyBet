using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ApuestaController : ApiController
    {

        // GET: api/Apuesta/5
        [Authorize(Roles = "admin")]
        public ApuestaDTO Get()
        {
            var repo = new ApuestaRepository();
            //Apuesta a = repo.Retrieve();          
            ApuestaDTO a = repo.RetrieveDTO();
            return a;
        }

        // POST: api/Apuesta
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Apuesta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuesta/5
        public void Delete(int id)
        {
        }
    }
}
