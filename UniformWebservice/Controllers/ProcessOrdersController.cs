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
    public class ProcessOrdersController : ApiController
    {
        private DBContext db = new DBContext();

        // GET: api/ProcessOrders
        public IQueryable<ProcessOrder> GetProcessOrders()
        {
            return db.ProcessOrders;
        }

        // GET: api/ProcessOrders/5
        [ResponseType(typeof(ProcessOrder))]
        public IHttpActionResult GetProcessOrder(int id)
        {
            ProcessOrder processOrder = db.ProcessOrders.Find(id);
            if (processOrder == null)
            {
                return NotFound();
            }

            return Ok(processOrder);
        }

        // PUT: api/ProcessOrders/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProcessOrder(int id, ProcessOrder processOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != processOrder.ProcessOrderNo)
            {
                return BadRequest();
            }

            db.Entry(processOrder).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcessOrderExists(id))
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

        // POST: api/ProcessOrders
        [ResponseType(typeof(ProcessOrder))]
        public IHttpActionResult PostProcessOrder(ProcessOrder processOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProcessOrders.Add(processOrder);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProcessOrderExists(processOrder.ProcessOrderNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = processOrder.ProcessOrderNo }, processOrder);
        }

        // DELETE: api/ProcessOrders/5
        [ResponseType(typeof(ProcessOrder))]
        public IHttpActionResult DeleteProcessOrder(int id)
        {
            ProcessOrder processOrder = db.ProcessOrders.Find(id);
            if (processOrder == null)
            {
                return NotFound();
            }

            db.ProcessOrders.Remove(processOrder);
            db.SaveChanges();

            return Ok(processOrder);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProcessOrderExists(int id)
        {
            return db.ProcessOrders.Count(e => e.ProcessOrderNo == id) > 0;
        }
    }
}