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
using MT_API.Models;

namespace MT_API.Controllers
{
    public class ArticleController : ApiController
    {
        private MTEntities db = new MTEntities();

        // GET: api/Article
        public IQueryable<ARTICLE> GetARTICLES()
        {
            return db.ARTICLES;
        }

        // GET: api/Article/5
        [ResponseType(typeof(ARTICLE))]
        public IHttpActionResult GetARTICLE(int id)
        {
            ARTICLE aRTICLE = db.ARTICLES.Find(id);
            if (aRTICLE == null)
            {
                return NotFound();
            }

            return Ok(aRTICLE);
        }

        // PUT: api/Article/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutARTICLE(int id, ARTICLE aRTICLE)
        {
            if (id != aRTICLE.ARTID)
            {
                return BadRequest();
            }

            db.Entry(aRTICLE).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ARTICLEExists(id))
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

        // POST: api/Article
        [ResponseType(typeof(ARTICLE))]
        public IHttpActionResult PostARTICLE(ARTICLE aRTICLE)
        {
            db.ARTICLES.Add(aRTICLE);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = aRTICLE.ARTID }, aRTICLE);
        }

        // DELETE: api/Article/5
        [ResponseType(typeof(ARTICLE))]
        public IHttpActionResult DeleteARTICLE(int id)
        {
            ARTICLE aRTICLE = db.ARTICLES.Find(id);
            if (aRTICLE == null)
            {
                return NotFound();
            }

            db.ARTICLES.Remove(aRTICLE);
            db.SaveChanges();

            return Ok(aRTICLE);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ARTICLEExists(int id)
        {
            return db.ARTICLES.Count(e => e.ARTID == id) > 0;
        }
    }
}