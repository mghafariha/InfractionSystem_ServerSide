using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Violations.Models;

namespace Violations.Controllers
{
    public class NotAllowedViolationsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/NotAllowedViolations
        [Queryable]
        public IQueryable<NotAllowedViolationsViewModel> GetNotAllowedViolations()
        {
            return db.Database.SqlQuery<NotAllowedViolationsViewModel>("getNotAllowViolation").AsQueryable();
        }
        [Queryable]
        public IQueryable<NotAllowedViolationsViewModel> GetNotAllowedViolations(string type)
        {

            return db.Database.SqlQuery<NotAllowedViolationsViewModel>("getNotAllowViolation @type", new SqlParameter("type", type)).AsQueryable();
        }

        // GET: api/NotAllowedViolations/5
        [ResponseType(typeof(NotAllowedViolations))]
        public IHttpActionResult GetNotAllowedViolations(int id)
        {
            NotAllowedViolations notAllowedViolations = db.NotAllowedViolations.Find(id);
            if (notAllowedViolations == null)
            {
                return NotFound();
            }

            return Ok(notAllowedViolations);
        }

        // PUT: api/NotAllowedViolations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNotAllowedViolations(int id, NotAllowedViolations notAllowedViolations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != notAllowedViolations.ID)
            {
                return BadRequest();
            }

            db.Entry(notAllowedViolations).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotAllowedViolationsExists(id))
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

        // POST: api/NotAllowedViolations
        [ResponseType(typeof(NotAllowedViolations))]
        public IHttpActionResult PostNotAllowedViolations(NotAllowedViolations notAllowedViolations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NotAllowedViolations.Add(notAllowedViolations);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = notAllowedViolations.ID }, notAllowedViolations);
        }

        // DELETE: api/NotAllowedViolations/5
        [ResponseType(typeof(NotAllowedViolations))]
        public IHttpActionResult DeleteNotAllowedViolations(int id)
        {
            NotAllowedViolations notAllowedViolations = db.NotAllowedViolations.Find(id);
            if (notAllowedViolations == null)
            {
                return NotFound();
            }

            db.NotAllowedViolations.Remove(notAllowedViolations);
            db.SaveChanges();

            return Ok(notAllowedViolations);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NotAllowedViolationsExists(int id)
        {
            return db.NotAllowedViolations.Count(e => e.ID == id) > 0;
        }
    }
}