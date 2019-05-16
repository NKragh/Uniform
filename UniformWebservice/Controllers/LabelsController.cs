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
    public class LabelsController : ApiController
    {
        private UniformContext db = new UniformContext();

        // GET: api/Labels
        public IQueryable<Label> GetLabels()
        {
            return db.Labels;
        }

        // GET: api/Labels/5
        [ResponseType(typeof(Label))]
        public IHttpActionResult GetLabel(int id)
        {
            Label label = db.Labels.Find(id);
            if (label == null)
            {
                return NotFound();
            }

            return Ok(label);
        }

        // PUT: api/Labels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLabel(int id, Label label)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != label.LabelNo)
            {
                return BadRequest();
            }

            db.Entry(label).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LabelExists(id))
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

        // POST: api/Labels
        [ResponseType(typeof(Label))]
        public IHttpActionResult PostLabel(Label label)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Labels.Add(label);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (LabelExists(label.LabelNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = label.LabelNo }, label);
        }

        // DELETE: api/Labels/5
        [ResponseType(typeof(Label))]
        public IHttpActionResult DeleteLabel(int id)
        {
            Label label = db.Labels.Find(id);
            if (label == null)
            {
                return NotFound();
            }

            db.Labels.Remove(label);
            db.SaveChanges();

            return Ok(label);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LabelExists(int id)
        {
            return db.Labels.Count(e => e.LabelNo == id) > 0;
        }
    }
}