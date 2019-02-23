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
    public class AreaStudiesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET api/AreaStudies
        public IQueryable<AreaStudy> GetAreaStudies()
        {
            return db.AreaStudies;
        }

        // GET api/AreaStudies/5
        [ResponseType(typeof(AreaStudy))]
        public IHttpActionResult GetAreaStudy(int id)
        {
            AreaStudy areastudy = db.AreaStudies.Find(id);
            if (areastudy == null)
            {
                return NotFound();
            }

            return Ok(areastudy);
        }

        // PUT api/AreaStudies/5
        public IHttpActionResult PutAreaStudy(int id, AreaStudy areastudy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != areastudy.ID)
            {
                return BadRequest();
            }

            db.Entry(areastudy).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AreaStudyExists(id))
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

        // POST api/AreaStudies
        [ResponseType(typeof(AreaStudy))]
        public IHttpActionResult PostAreaStudy(AreaStudy areastudy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AreaStudies.Add(areastudy);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = areastudy.ID }, areastudy);
        }

        // DELETE api/AreaStudies/5
        [ResponseType(typeof(AreaStudy))]
        public IHttpActionResult DeleteAreaStudy(int id)
        {
            AreaStudy areastudy = db.AreaStudies.Find(id);
            if (areastudy == null)
            {
                return NotFound();
            }

            db.AreaStudies.Remove(areastudy);
            db.SaveChanges();

            return Ok(areastudy);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AreaStudyExists(int id)
        {
            return db.AreaStudies.Count(e => e.ID == id) > 0;
        }
    }
}