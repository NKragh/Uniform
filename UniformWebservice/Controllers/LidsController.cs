using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using UniformWebservice.Models;

namespace UniformWebservice.Controllers
{
    public class LidsController : ApiController
    {
        private UniformContext db = new UniformContext();

        // GET: api/Lids
        public IQueryable<Lid> GetLids()
        {
            return db.Lids;
        }

        // GET: api/Lids/5
        [ResponseType(typeof(Lid))]
        public IHttpActionResult GetLid(int id)
        {
            Lid lid = db.Lids.Find(id);
            if (lid == null)
            {
                return NotFound();
            }

            return Ok(lid);
        }

        // PUT: api/Lids/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLid(int id, Lid lid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lid.LidNo)
            {
                return BadRequest();
            }

            db.Entry(lid).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LidExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Lids
        [ResponseType(typeof(Lid))]
        public IHttpActionResult PostLid(Lid lid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Lids.Add(lid);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (LidExists(lid.LidNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = lid.LidNo }, lid);
        }

        // DELETE: api/Lids/5
        [ResponseType(typeof(Lid))]
        public IHttpActionResult DeleteLid(int id)
        {
            Lid lid = db.Lids.Find(id);
            if (lid == null)
            {
                return NotFound();
            }

            db.Lids.Remove(lid);
            db.SaveChanges();

            return Ok(lid);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LidExists(int id)
        {
            return db.Lids.Count(e => e.LidNo == id) > 0;
        }
    }
}