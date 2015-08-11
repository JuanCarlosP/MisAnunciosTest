using misAnuncios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace misAnuncios.Controllers
{
    [RoutePrefix("api/EntradaDatos")]
    public class EntradaDatosController : ApiController
    {
        private int Nentradas = 5;
        EntradaDatos[] BBDD = new EntradaDatos[]
        {
            new EntradaDatos { Email = "admin", Password = "admin"},
            new EntradaDatos { Email = "1@gmail.com", Password = "1", Ciudad = "Madrid", Apellidos="SI", Nombre="SI", CatServicio="Jardineria"},
            new EntradaDatos { Email = "2@gmail.com", Password = "2", Ciudad = "Barcelona", Apellidos="NO", Nombre="NO", CatServicio="Jardineria"},
            new EntradaDatos { Email = "3@gmail.com", Password = "3", Ciudad = "Madrid", Apellidos="SI3", Nombre="SI3", CatServicio="Jardineria"},
            new EntradaDatos { Email = "4@gmail.com", Password = "3", Ciudad = "Madrid", Apellidos="SI3", Nombre="SI3", CatServicio="Jardineria"},
        };

        // GET: api/EntradaDatos
        [Route("")]
        public IEnumerable<EntradaDatos> Get()
        {
            EntradaDatos[] BBDDAux = new EntradaDatos[Nentradas];

            for (int i = 0; i < Nentradas; i++)
            {
                BBDDAux[i] = BBDD[i];
            }

            return BBDD;
        }

        //GET: api/EntradaDatos/Madrid
        [Route("{Ciudad}")]
        public IEnumerable<EntradaDatos> Get(string Ciudad)
        {
            EntradaDatos[] BBDDAux;
            int contador = 0;

            for (int i = 1; i < Nentradas; i++)
            {
                if (BBDD[i].Ciudad.Equals(Ciudad, StringComparison.OrdinalIgnoreCase))
                {
                    contador++;
                }
            }
            BBDDAux = new EntradaDatos[contador];
            contador = 0;
            for (int i = 1; i < Nentradas; i++)
            {
                if (BBDD[i].Ciudad.Equals(Ciudad, StringComparison.OrdinalIgnoreCase))
                {
                    BBDDAux[contador] = BBDD[i];
                    contador++;
                }
            }
            return BBDDAux;
        }


        // GET: api/EntradaDatos/5
        [Route("{id:int}")]
        public EntradaDatos Get(int id)
        {
            return BBDD[id];
        }

        // POST: api/EntradaDatos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EntradaDatos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EntradaDatos/5
        public void Delete(int id)
        {
        }
    }
}
