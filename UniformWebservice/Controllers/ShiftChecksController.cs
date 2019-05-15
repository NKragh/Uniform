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
    public class ShiftChecksController : ApiController
    {
        private UniformContext db = new UniformContext();

        // GET: api/ShiftChecks
        public IQueryable<ShiftCheck> GetShiftCheck()
        {
            return db.ShiftCheck;
        }

        // GET: api/ShiftChecks/5
        [ResponseType(typeof(ShiftCheck))]
        public IHttpActionResult GetShiftCheck(int id)
        {
            ShiftCheck shiftCheck = db.ShiftCheck.Find(id);
            if (shiftCheck == null)
            {
                return NotFound();
            }

            return Ok(shiftCheck);
        }

        // PUT: api/ShiftChecks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutShiftCheck(int id, ShiftCheck shiftCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shiftCheck.ProcessOrderNo)
            {
                return BadRequest();
            }

            db.Entry(shiftCheck).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShiftCheckExists(id))
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

        // POST: api/ShiftChecks
        [ResponseType(typeof(ShiftCheck))]
        public IHttpActionResult PostShiftCheck(ShiftCheck shiftCheck)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ShiftCheck.Add(shiftCheck);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ShiftCheckExists(shiftCheck.ProcessOrderNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = shiftCheck.ProcessOrderNo }, shiftCheck);
        }

        // DELETE: api/ShiftChecks/5
        [ResponseType(typeof(ShiftCheck))]
        public IHttpActionResult DeleteShiftCheck(int id)
        {
            ShiftCheck shiftCheck = db.ShiftCheck.Find(id);
            if (shiftCheck == null)
            {
                return NotFound();
            }

            db.ShiftCheck.Remove(shiftCheck);
            db.SaveChanges();

            return Ok(shiftCheck);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ShiftCheckExists(int id)
        {
            return db.ShiftCheck.Count(e => e.ProcessOrderNo == id) > 0;
        }
    }
}