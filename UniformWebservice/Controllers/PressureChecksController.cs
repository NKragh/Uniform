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
    public class PressureChecksController : ApiController
    {
        private UniformContext db = new UniformContext();

        // GET: api/PressureChecks
        public IQueryable<PressureCheck> GetPressureCheck()
        {
            return db.PressureCheck;
        }

        // GET: api/PressureChecks/5
        [ResponseType(typeof(PressureCheck))]
        public IHttpActionResult GetPressureCheck(int id)
        {
            PressureCheck pressureCheck = db.PressureCheck.Find(id);
            if (pressureCheck == null)
            {
                return NotFound();
            }

            return Ok(pressureCheck);
        }

        // PUT: api/PressureChecks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPressureCheck(int id, PressureCheck pressureCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pressureCheck.ProcessOrderNo)
            {
                return BadRequest();
            }

            db.Entry(pressureCheck).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PressureCheckExists(id))
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

        // POST: api/PressureChecks
        [ResponseType(typeof(PressureCheck))]
        public IHttpActionResult PostPressureCheck(PressureCheck pressureCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PressureCheck.Add(pressureCheck);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PressureCheckExists(pressureCheck.ProcessOrderNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pressureCheck.ProcessOrderNo }, pressureCheck);
        }

        // DELETE: api/PressureChecks/5
        [ResponseType(typeof(PressureCheck))]
        public IHttpActionResult DeletePressureCheck(int id)
        {
            PressureCheck pressureCheck = db.PressureCheck.Find(id);
            if (pressureCheck == null)
            {
                return NotFound();
            }

            db.PressureCheck.Remove(pressureCheck);
            db.SaveChanges();

            return Ok(pressureCheck);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PressureCheckExists(int id)
        {
            return db.PressureCheck.Count(e => e.ProcessOrderNo == id) > 0;
        }
    }
}