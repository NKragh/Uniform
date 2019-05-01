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
    public class BatchesController : ApiController
    {
        private DBContext db = new DBContext();

        // GET: api/Batches
        public IQueryable<Batch> GetBatches()
        {
            return db.Batches;
        }

        // GET: api/Batches/5
        [ResponseType(typeof(Batch))]
        public IHttpActionResult GetBatch(string id)
        {
            Batch batch = db.Batches.Find(id);
            if (batch == null)
            {
                return NotFound();
            }

            return Ok(batch);
        }

        // PUT: api/Batches/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBatch(string id, Batch batch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != batch.BatchCode)
            {
                return BadRequest();
            }

            db.Entry(batch).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BatchExists(id))
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

        // POST: api/Batches
        [ResponseType(typeof(Batch))]
        public IHttpActionResult PostBatch(Batch batch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Batches.Add(batch);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (BatchExists(batch.BatchCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = batch.BatchCode }, batch);
        }

        // DELETE: api/Batches/5
        [ResponseType(typeof(Batch))]
        public IHttpActionResult DeleteBatch(string id)
        {
            Batch batch = db.Batches.Find(id);
            if (batch == null)
            {
                return NotFound();
            }

            db.Batches.Remove(batch);
            db.SaveChanges();

            return Ok(batch);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BatchExists(string id)
        {
            return db.Batches.Count(e => e.BatchCode == id) > 0;
        }
    }
}