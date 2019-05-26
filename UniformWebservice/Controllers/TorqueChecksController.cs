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
    public class TorqueChecksController : ApiController
    {
        private UniformContext db = new UniformContext();

        // GET: api/TorqueChecks
        public IQueryable<TorqueCheck> GetTorqueChecks()
        {
            return db.TorqueChecks;
        }

        // GET: api/TorqueChecks/5
        [ResponseType(typeof(TorqueCheck))]
        public IHttpActionResult GetTorqueCheck(int id)
        {
            TorqueCheck torqueCheck = db.TorqueChecks.Find(id);
            if (torqueCheck == null)
            {
                return NotFound();
            }

            return Ok(torqueCheck);
        }

        // PUT: api/TorqueChecks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTorqueCheck(int id, TorqueCheck torqueCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != torqueCheck.ProcessOrderNo)
            {
                return BadRequest();
            }

            db.Entry(torqueCheck).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TorqueCheckExists(id))
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

        // POST: api/TorqueChecks
        [ResponseType(typeof(TorqueCheck))]
        public IHttpActionResult PostTorqueCheck(TorqueCheck torqueCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TorqueChecks.Add(torqueCheck);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (TorqueCheckExists(torqueCheck.ProcessOrderNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = torqueCheck.ProcessOrderNo }, torqueCheck);
        }

        // DELETE: api/TorqueChecks/5
        [ResponseType(typeof(TorqueCheck))]
        public IHttpActionResult DeleteTorqueCheck(int id)
        {
            TorqueCheck torqueCheck = db.TorqueChecks.Find(id);
            if (torqueCheck == null)
            {
                return NotFound();
            }

            db.TorqueChecks.Remove(torqueCheck);
            db.SaveChanges();

            return Ok(torqueCheck);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TorqueCheckExists(int id)
        {
            return db.TorqueChecks.Count(e => e.ProcessOrderNo == id) > 0;
        }
    }
}