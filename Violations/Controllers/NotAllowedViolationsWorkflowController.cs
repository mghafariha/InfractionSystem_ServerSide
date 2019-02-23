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
using Violations.Models;

namespace Violations.Controllers
{
    public class NotAllowedViolationsWorkflowController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET api/NotAllowedViolationsWorkflow
        [Queryable]
        public IQueryable<NotAllowedViolationsWorkflow> GetNotAllowedViolationsWorkflows()
        {
            return db.NotAllowedViolationsWorkflows;
        }

        // GET api/NotAllowedViolationsWorkflow/5
        [ResponseType(typeof(NotAllowedViolationsWorkflow))]
        public IHttpActionResult GetNotAllowedViolationsWorkflow(int id)
        {
            NotAllowedViolationsWorkflow notallowedviolationsworkflow = db.NotAllowedViolationsWorkflows.Find(id);
            if (notallowedviolationsworkflow == null)
            {
                return NotFound();
            }

            return Ok(notallowedviolationsworkflow);
        }

        // PUT api/NotAllowedViolationsWorkflow/5
        public IHttpActionResult PutNotAllowedViolationsWorkflow(int id, NotAllowedViolationsWorkflow notallowedviolationsworkflow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != notallowedviolationsworkflow.ID)
            {
                return BadRequest();
            }

            db.Entry(notallowedviolationsworkflow).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotAllowedViolationsWorkflowExists(id))
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

        // POST api/NotAllowedViolationsWorkflow
        [ResponseType(typeof(NotAllowedViolationsWorkflow))]
        public IHttpActionResult PostNotAllowedViolationsWorkflow(NotAllowedViolationsWorkflow notallowedviolationsworkflow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NotAllowedViolationsWorkflows.Add(notallowedviolationsworkflow);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = notallowedviolationsworkflow.ID }, notallowedviolationsworkflow);
        }

        // DELETE api/NotAllowedViolationsWorkflow/5
        [ResponseType(typeof(NotAllowedViolationsWorkflow))]
        public IHttpActionResult DeleteNotAllowedViolationsWorkflow(int id)
        {
            NotAllowedViolationsWorkflow notallowedviolationsworkflow = db.NotAllowedViolationsWorkflows.Find(id);
            if (notallowedviolationsworkflow == null)
            {
                return NotFound();
            }

            db.NotAllowedViolationsWorkflows.Remove(notallowedviolationsworkflow);
            db.SaveChanges();

            return Ok(notallowedviolationsworkflow);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NotAllowedViolationsWorkflowExists(int id)
        {
            return db.NotAllowedViolationsWorkflows.Count(e => e.ID == id) > 0;
        }
    }
}