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
    public class LabelChecksController : ApiController
    {
        private UniformContext db = new UniformContext();

        // GET: api/LabelChecks
        public IQueryable<LabelCheck> GetLabelChecks()
        {
            return db.LabelChecks;
        }

        // GET: api/LabelChecks/5
        [ResponseType(typeof(LabelCheck))]
        public IHttpActionResult GetLabelCheck(int id)
        {
            LabelCheck labelCheck = db.LabelChecks.Find(id);
            if (labelCheck == null)
            {
                return NotFound();
            }

            return Ok(labelCheck);
        }

        // PUT: api/LabelChecks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLabelCheck(int id, LabelCheck labelCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != labelCheck.ProcessOrderNo)
            {
                return BadRequest();
            }

            db.Entry(labelCheck).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LabelCheckExists(id))
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

        // POST: api/LabelChecks
        [ResponseType(typeof(LabelCheck))]
        public IHttpActionResult PostLabelCheck(LabelCheck labelCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LabelChecks.Add(labelCheck);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (LabelCheckExists(labelCheck.ProcessOrderNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = labelCheck.ProcessOrderNo }, labelCheck);
        }

        // DELETE: api/LabelChecks/5
        [ResponseType(typeof(LabelCheck))]
        public IHttpActionResult DeleteLabelCheck(int id)
        {
            LabelCheck labelCheck = db.LabelChecks.Find(id);
            if (labelCheck == null)
            {
                return NotFound();
            }

            db.LabelChecks.Remove(labelCheck);
            db.SaveChanges();

            return Ok(labelCheck);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LabelCheckExists(int id)
        {
            return db.LabelChecks.Count(e => e.ProcessOrderNo == id) > 0;
        }
    }
}