using Estacionamiento.Context;
using Estacionamiento.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamiento.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]

    public class PlazaController : ControllerBase
    {
        private readonly EstacionamientoDbContext db;
        private EntityState entityState;

        public PlazaController(EstacionamientoDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        [Route("GetAll")] // si le agrego la barra elimino la ruta absoluta y la dejo relativa 
        public ActionResult<IEnumerable<Plaza>> Get()
        {
            return db.Plazas.ToList();
            // db.Plazas.Where(x => x.Estado == true).ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Plaza> Get(int id)
        {
            Plaza plaza = db.Plazas.FirstOrDefault(x => x.Id == id);
            if (plaza == null)
            {
                return NotFound();
            }
            return plaza;
        }
        [HttpPost]
        public ActionResult<Plaza> Post([FromBody] Plaza plaza)
        {
            db.Add(plaza);
            db.SaveChanges();
            return plaza;
        }
        [HttpPut("{id}")]
        public ActionResult<Plaza> Put(int id, [FromBody] Plaza plaza)
        {
            if (id != plaza.Id)
            {
                return BadRequest();
            }
            //var plazaModif = db.Plazas.FirstOrDefault(x => x.Id == id);
            plaza.Estado = !plaza.Estado;
            db.Entry(plaza).State = EntityState.Modified;
            db.SaveChanges();
            return plaza;

        }
        [HttpDelete("{id}")]
        public ActionResult<Plaza> Delete(int id)
        {
            Plaza plaza = db.Plazas.FirstOrDefault(x => x.Id == id);
            if (plaza == null)
            {
                return NotFound();
            }
            db.Remove(plaza);
            db.SaveChanges();
            return plaza;
        }

  
    }
}
