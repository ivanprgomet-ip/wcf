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
using L04E02.Books;
using L04E02.Books.Models;

namespace L04E02.Books.Controllers
{
    public class AuthorsController : ApiController
    {
        private BooksEntities db = new BooksEntities();

        // GET: api/Authors
        public IHttpActionResult GetAuthors()
        {
            var authors = new List<Author>();
            foreach (var a in db.Authors)
            {
                authors.Add(new Author()
                {
                    AuthorID = a.AuthorID,
                    PaymentMethod = a.PaymentMethod,
                    CountryOfResidence = a.CountryOfResidence,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    HomeTel = a.HomeTel,
                });
            }
            return Ok(authors);
        }

        // GET: api/Authors/5
        [ResponseType(typeof(Author))]
        public IHttpActionResult GetAuthor(int id)
        {
            Author author = db.Authors.Find(id);

            // neccessary to do this to not get a 'self referencing loop detected' error from EF
            Author result = new Author()
            {
                AuthorID = author.AuthorID,
                FirstName = author.FirstName,
                LastName = author.LastName,
            };

            if (author == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // PUT: api/Authors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAuthor(int id, Author author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != author.AuthorID)
            {
                return BadRequest();
            }

            db.Entry(author).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorExists(id))
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

        // POST: api/Authors
        [ResponseType(typeof(Author))]
        public IHttpActionResult PostAuthor(Author author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Authors.Add(author);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = author.AuthorID }, author);
        }

        // DELETE: api/Authors/5
        [ResponseType(typeof(Author))]
        public IHttpActionResult DeleteAuthor(int id)
        {
            Author author = db.Authors.Find(id);
            if (author == null)
            {
                return NotFound();
            }

            db.Authors.Remove(author);
            db.SaveChanges();

            return Ok(author);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AuthorExists(int id)
        {
            return db.Authors.Count(e => e.AuthorID == id) > 0;
        }
    }
}