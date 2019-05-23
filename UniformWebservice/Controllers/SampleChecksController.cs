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
    public class SampleChecksController : ApiController
    {
        private UniformContext db = new UniformContext();

        // GET: api/SampleChecks
        public IQueryable<SampleCheck> GetSampleChecks()
        {
            return db.SampleChecks;
        }

        // GET: api/SampleChecks/5
        [ResponseType(typeof(SampleCheck))]
        public IHttpActionResult GetSampleCheck(int id)
        {
            SampleCheck sampleCheck = db.SampleChecks.Find(id);
            if (sampleCheck == null)
            {
                return NotFound();
            }

            return Ok(sampleCheck);
        }

        // PUT: api/SampleChecks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSampleCheck(int id, SampleCheck sampleCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sampleCheck.ProcessOrderNo)
            {
                return BadRequest();
            }

            db.Entry(sampleCheck).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SampleCheckExists(id))
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

        // POST: api/SampleChecks
        [ResponseType(typeof(SampleCheck))]
        public IHttpActionResult PostSampleCheck(SampleCheck sampleCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SampleChecks.Add(sampleCheck);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SampleCheckExists(sampleCheck.ProcessOrderNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sampleCheck.ProcessOrderNo }, sampleCheck);
        }

        // DELETE: api/SampleChecks/5
        [ResponseType(typeof(SampleCheck))]
        public IHttpActionResult DeleteSampleCheck(int id)
        {
            SampleCheck sampleCheck = db.SampleChecks.Find(id);
            if (sampleCheck == null)
            {
                return NotFound();
            }

            db.SampleChecks.Remove(sampleCheck);
            db.SaveChanges();

            return Ok(sampleCheck);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SampleCheckExists(int id)
        {
            return db.SampleChecks.Count(e => e.ProcessOrderNo == id) > 0;
        }
    }
}