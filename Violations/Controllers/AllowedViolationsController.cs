using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Violations.Models;

namespace Violations.Controllers
{
    public class AllowedViolationsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/AllowedViolations
        [Queryable]
        public IQueryable<AllowedViolationsViewModel> GetAllowedViolations()
        {
//            string sqlString = @"SELECT *,(select top 1 step FROM [InfractionDB].[dbo].[AllowedViolationsWorkflows] as w where x.[InfractionType] like w.[InfractionType] and w.ViolationId =x.ID) state2
//                                FROM [InfractionDB].[dbo].[AllowedViolations] as x";

//            var objctx = (db as IObjectContextAdapter).ObjectContext;

//            ObjectQuery<AllowedViolations> data = objctx.CreateQuery<AllowedViolations>(sqlString);
            return db.Database.SqlQuery<AllowedViolationsViewModel>("getAllowViolation").AsQueryable();
             
        }

        // GET: api/AllowedViolations/5
        [ResponseType(typeof(AllowedViolations))]
        public IHttpActionResult GetAllowedViolations(int id)
        {
            AllowedViolations allowedViolations = db.AllowedViolations.Find(id);
            if (allowedViolations == null)
            {
                return NotFound();
            }

            return Ok(allowedViolations);
        }

        // PUT: api/AllowedViolations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAllowedViolations(int id, AllowedViolations allowedViolations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != allowedViolations.ID)
            {
                return BadRequest();
            }

            db.Entry(allowedViolations).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AllowedViolationsExists(id))
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

        // POST: api/AllowedViolations
        [ResponseType(typeof(AllowedViolations))]
        public IHttpActionResult PostAllowedViolations(AllowedViolations allowedViolations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AllowedViolations.Add(allowedViolations);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = allowedViolations.ID }, allowedViolations);
        }

        // DELETE: api/AllowedViolations/5
        [ResponseType(typeof(AllowedViolations))]
        public IHttpActionResult DeleteAllowedViolations(int id)
        {
            AllowedViolations allowedViolations = db.AllowedViolations.Find(id);
            if (allowedViolations == null)
            {
                return NotFound();
            }

            db.AllowedViolations.Remove(allowedViolations);
            db.SaveChanges();

            return Ok(allowedViolations);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AllowedViolationsExists(int id)
        {
            return db.AllowedViolations.Count(e => e.ID == id) > 0;
        }
    }
}