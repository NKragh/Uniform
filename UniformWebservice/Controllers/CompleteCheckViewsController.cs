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
    public class CompleteCheckViewsController : ApiController
    {
        private UniformContext db = new UniformContext();

        // GET: api/CompleteCheckViews
        public IQueryable<CompleteCheckView> GetCompleteCheckViews()
        {
            return db.CompleteCheckViews;
        }

        // GET: api/CompleteCheckViews/5
        [ResponseType(typeof(CompleteCheckView))]
        public IHttpActionResult GetCompleteCheckView(int id)
        {
            CompleteCheckView completeCheckView = db.CompleteCheckViews.Find(id);
            if (completeCheckView == null)
            {
                return NotFound();
            }

            return Ok(completeCheckView);
        }

        // PUT: api/CompleteCheckViews/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleteCheckView(int id, CompleteCheckView completeCheckView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completeCheckView.ProductNo)
            {
                return BadRequest();
            }

            db.Entry(completeCheckView).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompleteCheckViewExists(id))
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

        // POST: api/CompleteCheckViews
        [ResponseType(typeof(CompleteCheckView))]
        public IHttpActionResult PostCompleteCheckView(CompleteCheckView completeCheckView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CompleteCheckViews.Add(completeCheckView);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CompleteCheckViewExists(completeCheckView.ProductNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = completeCheckView.ProductNo }, completeCheckView);
        }

        // DELETE: api/CompleteCheckViews/5
        [ResponseType(typeof(CompleteCheckView))]
        public IHttpActionResult DeleteCompleteCheckView(int id)
        {
            CompleteCheckView completeCheckView = db.CompleteCheckViews.Find(id);
            if (completeCheckView == null)
            {
                return NotFound();
            }

            db.CompleteCheckViews.Remove(completeCheckView);
            db.SaveChanges();

            return Ok(completeCheckView);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CompleteCheckViewExists(int id)
        {
            return db.CompleteCheckViews.Count(e => e.ProductNo == id) > 0;
        }
    }
}