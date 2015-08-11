using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace misAnunciosWeb.Controllers
{
    public class CategoriasController : ApiController
    {
        List<string> categorias = new List<string>(2) { "Jardineria", "Fontaneria" };

        // GET: api/Categorias
        public IEnumerable<string> Get()
        {
            return categorias;
        }

        // GET: api/Categorias/5
        public string Get(int id)
        {
            return categorias[id];
        }

        // POST: api/Categorias
        public void Post([FromBody]string value)
        {
            categorias.Add(value);
        }

        
        // DELETE: api/Categorias/5
        public void Delete(string id)
        {
            categorias.Remove(id);
        }
    }
}
