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
using CarRentalSystem.Models;

namespace CarRentalSystem.Controllers
{
    [RoutePrefix("api/bookingdetails")]
    public class BookingDetailsController : ApiController
    {
        private RentalDbContext db = new RentalDbContext();

        // GET: api/BookingDetails
        public IQueryable<BookingDetails> GetBookingDetail()
        {
            return db.BookingDetail;
        }

        // GET: api/BookingDetails/5
        [ResponseType(typeof(BookingDetails))]
        public IHttpActionResult GetBookingDetails(int id)
        {
            BookingDetails bookingDetails = db.BookingDetail.Find(id);
            if (bookingDetails == null)
            {
                return NotFound();
            }

            return Ok(bookingDetails);
        }

        // PUT: api/BookingDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBookingDetails(int id, BookingDetails bookingDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bookingDetails.ID)
            {
                return BadRequest();
            }

            db.Entry(bookingDetails).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingDetailsExists(id))
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

        // POST: api/BookingDetails
        [ResponseType(typeof(BookingDetails))]
        public IHttpActionResult PostBookingDetails(BookingDetails bookingDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BookingDetail.Add(bookingDetails);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bookingDetails.ID }, bookingDetails);
        }

        // DELETE: api/BookingDetails/5
        [ResponseType(typeof(BookingDetails))]
        public IHttpActionResult DeleteBookingDetails(int id)
        {
            BookingDetails bookingDetails = db.BookingDetail.Find(id);
            if (bookingDetails == null)
            {
                return NotFound();
            }

            db.BookingDetail.Remove(bookingDetails);
            db.SaveChanges();

            return Ok(bookingDetails);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BookingDetailsExists(int id)
        {
            return db.BookingDetail.Count(e => e.ID == id) > 0;
        }
    }
}