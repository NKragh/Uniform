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
    public class PreformsController : ApiController
    {
        private UniformContext db = new UniformContext();

        // GET: api/Preforms
        public IQueryable<Preform> GetPreform()
        {
            return db.Preform;
        }

        // GET: api/Preforms/5
        [ResponseType(typeof(Preform))]
        public IHttpActionResult GetPreform(int id)
        {
            Preform preform = db.Preform.Find(id);
            if (preform == null)
            {
                return NotFound();
            }

            return Ok(preform);
        }

        // PUT: api/Preforms/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPreform(int id, Preform preform)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != preform.PreformNo)
            {
                return BadRequest();
            }

            db.Entry(preform).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PreformExists(id))
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

        // POST: api/Preforms
        [ResponseType(typeof(Preform))]
        public IHttpActionResult PostPreform(Preform preform)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Preform.Add(preform);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PreformExists(preform.PreformNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = preform.PreformNo }, preform);
        }

        // DELETE: api/Preforms/5
        [ResponseType(typeof(Preform))]
        public IHttpActionResult DeletePreform(int id)
        {
            Preform preform = db.Preform.Find(id);
            if (preform == null)
            {
                return NotFound();
            }

            db.Preform.Remove(preform);
            db.SaveChanges();

            return Ok(preform);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PreformExists(int id)
        {
            return db.Preform.Count(e => e.PreformNo == id) > 0;
        }
    }
}