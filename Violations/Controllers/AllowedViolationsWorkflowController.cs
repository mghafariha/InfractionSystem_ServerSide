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
    public class AllowedViolationsWorkflowController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET api/AllowedViolationsWorkflow
        [Queryable]
        public IQueryable<AllowedViolationsWorkflow> GetAllowedViolationsWorkflows()
        {
            return db.AllowedViolationsWorkflows;
        }

        // GET api/AllowedViolationsWorkflow/5
        [ResponseType(typeof(AllowedViolationsWorkflow))]
        public IHttpActionResult GetAllowedViolationsWorkflow(int id)
        {
            AllowedViolationsWorkflow allowedviolationsworkflow = db.AllowedViolationsWorkflows.Find(id);
            if (allowedviolationsworkflow == null)
            {
                return NotFound();
            }

            return Ok(allowedviolationsworkflow);
        }

        // PUT api/AllowedViolationsWorkflow/5
        public IHttpActionResult PutAllowedViolationsWorkflow(int id, AllowedViolationsWorkflow allowedviolationsworkflow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != allowedviolationsworkflow.ID)
            {
                return BadRequest();
            }

            db.Entry(allowedviolationsworkflow).State = EntityState.Modified;

            try
            {

                AllowedViolations allowViolation = db.AllowedViolations.Find(allowedviolationsworkflow.ViolationId);
                db.Entry(allowViolation).State = EntityState.Modified;
                allowViolation.Status = allowedviolationsworkflow.Step;
                db.SaveChanges();


            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AllowedViolationsWorkflowExists(id))
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

        // POST api/AllowedViolationsWorkflow
        [ResponseType(typeof(AllowedViolationsWorkflow))]
        public IHttpActionResult PostAllowedViolationsWorkflow(AllowedViolationsWorkflow allowedviolationsworkflow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AllowedViolationsWorkflows.Add(allowedviolationsworkflow);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = allowedviolationsworkflow.ID }, allowedviolationsworkflow);
        }

        // DELETE api/AllowedViolationsWorkflow/5
        [ResponseType(typeof(AllowedViolationsWorkflow))]
        public IHttpActionResult DeleteAllowedViolationsWorkflow(int id)
        {
            AllowedViolationsWorkflow allowedviolationsworkflow = db.AllowedViolationsWorkflows.Find(id);
            if (allowedviolationsworkflow == null)
            {
                return NotFound();
            }

            db.AllowedViolationsWorkflows.Remove(allowedviolationsworkflow);
            db.SaveChanges();

            return Ok(allowedviolationsworkflow);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AllowedViolationsWorkflowExists(int id)
        {
            return db.AllowedViolationsWorkflows.Count(e => e.ID == id) > 0;
        }
    }
}