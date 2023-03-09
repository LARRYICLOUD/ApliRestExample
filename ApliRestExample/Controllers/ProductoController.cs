using ApliRestExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApliRestExample.Controllers
{
    public class ProductoController : ApiController    {
        UniversityEntities db = new UniversityEntities();           


        // GET api/<controller>
        public List<Estudiante> Get()
        {
            return db.Estudiante.ToList();
        }

        // GET api/<controller>/5
        public Estudiante Get(int id_cliente)
        {
            return db.Estudiante.Find(id_cliente);
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5 atravez de la url recibimos la llave primaria consultamos  si existe
        public void Delete(int id)
        {
        }
    }
}