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
using UniformWebservice;
using UniformWebservice.Models;

namespace UniformWebservice.Controllers
{
    public class TasteChecksController : ApiController
    {
        private UniformContext db = new UniformContext();

        // GET: api/TasteChecks
        public IQueryable<TasteCheck> GetTasteChecks()
        {
            return db.TasteChecks;
        }

        // GET: api/TasteChecks/5
        [ResponseType(typeof(TasteCheck))]
        public IHttpActionResult GetTasteCheck(int id)
        {
            TasteCheck tasteCheck = db.TasteChecks.Find(id);
            if (tasteCheck == null)
            {
                return NotFound();
            }

            return Ok(tasteCheck);
        }

        // PUT: api/TasteChecks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTasteCheck(int id, TasteCheck tasteCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tasteCheck.ProcessOrderNo)
            {
                return BadRequest();
            }

            db.Entry(tasteCheck).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TasteCheckExists(id))
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

        // POST: api/TasteChecks
        [ResponseType(typeof(TasteCheck))]
        public IHttpActionResult PostTasteCheck(TasteCheck tasteCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TasteChecks.Add(tasteCheck);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (TasteCheckExists(tasteCheck.ProcessOrderNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tasteCheck.ProcessOrderNo }, tasteCheck);
        }

        // DELETE: api/TasteChecks/5
        [ResponseType(typeof(TasteCheck))]
        public IHttpActionResult DeleteTasteCheck(int id)
        {
            TasteCheck tasteCheck = db.TasteChecks.Find(id);
            if (tasteCheck == null)
            {
                return NotFound();
            }

            db.TasteChecks.Remove(tasteCheck);
            db.SaveChanges();

            return Ok(tasteCheck);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TasteCheckExists(int id)
        {
            return db.TasteChecks.Count(e => e.ProcessOrderNo == id) > 0;
        }
    }
}