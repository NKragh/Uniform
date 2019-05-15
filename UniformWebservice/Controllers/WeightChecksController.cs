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
    public class WeightChecksController : ApiController
    {
        private UniformContext db = new UniformContext();

        // GET: api/WeightChecks
        public IQueryable<WeightCheck> GetWeightCheck()
        {
            return db.WeightCheck;
        }

        // GET: api/WeightChecks/5
        [ResponseType(typeof(WeightCheck))]
        public IHttpActionResult GetWeightCheck(int id)
        {
            WeightCheck weightCheck = db.WeightCheck.Find(id);
            if (weightCheck == null)
            {
                return NotFound();
            }

            return Ok(weightCheck);
        }

        // PUT: api/WeightChecks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWeightCheck(int id, WeightCheck weightCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != weightCheck.ProcessOrderNo)
            {
                return BadRequest();
            }

            db.Entry(weightCheck).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeightCheckExists(id))
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

        // POST: api/WeightChecks
        [ResponseType(typeof(WeightCheck))]
        public IHttpActionResult PostWeightCheck(WeightCheck weightCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WeightCheck.Add(weightCheck);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (WeightCheckExists(weightCheck.ProcessOrderNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = weightCheck.ProcessOrderNo }, weightCheck);
        }

        // DELETE: api/WeightChecks/5
        [ResponseType(typeof(WeightCheck))]
        public IHttpActionResult DeleteWeightCheck(int id)
        {
            WeightCheck weightCheck = db.WeightCheck.Find(id);
            if (weightCheck == null)
            {
                return NotFound();
            }

            db.WeightCheck.Remove(weightCheck);
            db.SaveChanges();

            return Ok(weightCheck);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WeightCheckExists(int id)
        {
            return db.WeightCheck.Count(e => e.ProcessOrderNo == id) > 0;
        }
    }
}