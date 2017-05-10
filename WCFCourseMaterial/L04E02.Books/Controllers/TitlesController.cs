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
using L04E02.Books.Models;

namespace L04E02.Books.Controllers
{
    public class TitlesController : ApiController
    {
        private BooksEntities db = new BooksEntities();

        // GET: api/Titles
        public IHttpActionResult GetTitles()
        {
            var titles = new List<Title>();
            foreach (var a in db.Titles)
            {
                titles.Add(new Title()
                {
                    ISBN= a.ISBN,
                    Title1 = a.Title1,
                });
            }
            return Ok(titles);
        }

        // GET: api/Titles/5
        [ResponseType(typeof(Title))]
        public IHttpActionResult GetTitle(string id)
        {
            Title title = db.Titles.Find(id);

            Title result = new Title()
            {
                ISBN = title.ISBN,
                Title1 = title.Title1,
            };

            if (title == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // PUT: api/Titles/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTitle(string id, Title title)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != title.ISBN)
            {
                return BadRequest();
            }

            db.Entry(title).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TitleExists(id))
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

        // POST: api/Titles
        [ResponseType(typeof(Title))]
        public IHttpActionResult PostTitle(Title title)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Titles.Add(title);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (TitleExists(title.ISBN))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = title.ISBN }, title);
        }

        // DELETE: api/Titles/5
        [ResponseType(typeof(Title))]
        public IHttpActionResult DeleteTitle(string id)
        {
            Title title = db.Titles.Find(id);
            if (title == null)
            {
                return NotFound();
            }

            db.Titles.Remove(title);
            db.SaveChanges();

            return Ok(title);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TitleExists(string id)
        {
            return db.Titles.Count(e => e.ISBN == id) > 0;
        }
    }
}