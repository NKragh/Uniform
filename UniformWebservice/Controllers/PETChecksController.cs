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
    public class PETChecksController : ApiController
    {
        private UniformContext db = new UniformContext();

        // GET: api/PETChecks
        public IQueryable<PETCheck> GetPETChecks()
        {
            return db.PETChecks;
        }

        // GET: api/PETChecks/5
        [ResponseType(typeof(PETCheck))]
        public IHttpActionResult GetPETCheck(int id)
        {
            PETCheck pETCheck = db.PETChecks.Find(id);
            if (pETCheck == null)
            {
                return NotFound();
            }

            return Ok(pETCheck);
        }

        // PUT: api/PETChecks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPETCheck(int id, PETCheck pETCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pETCheck.ProcessOrderNo)
            {
                return BadRequest();
            }

            db.Entry(pETCheck).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PETCheckExists(id))
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

        // POST: api/PETChecks
        [ResponseType(typeof(PETCheck))]
        public IHttpActionResult PostPETCheck(PETCheck pETCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PETChecks.Add(pETCheck);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PETCheckExists(pETCheck.ProcessOrderNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pETCheck.ProcessOrderNo }, pETCheck);
        }

        // DELETE: api/PETChecks/5
        [ResponseType(typeof(PETCheck))]
        public IHttpActionResult DeletePETCheck(int id)
        {
            PETCheck pETCheck = db.PETChecks.Find(id);
            if (pETCheck == null)
            {
                return NotFound();
            }

            db.PETChecks.Remove(pETCheck);
            db.SaveChanges();

            return Ok(pETCheck);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PETCheckExists(int id)
        {
            return db.PETChecks.Count(e => e.ProcessOrderNo == id) > 0;
        }
    }
}