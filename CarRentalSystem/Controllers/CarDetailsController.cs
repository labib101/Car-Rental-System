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
    
    [RoutePrefix("api/cardetails")]
    public class CarDetailsController : ApiController
    {
        private RentalDbContext db = new RentalDbContext();

        // GET: api/CarDetails
        public IQueryable<CarDetails> GetCarDetail()
        {
            return db.CarDetail;
        }

        // GET: api/CarDetails/5
        [ResponseType(typeof(CarDetails))]
        public IHttpActionResult GetCarDetails(int id)
        {
            CarDetails carDetails = db.CarDetail.Find(id);
            if (carDetails == null)
            {
                return NotFound();
            }

            return Ok(carDetails);
        }

        // PUT: api/CarDetails/5
        [Route("PutCarDetails")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCarDetails(int id, CarDetails carDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carDetails.ID)
            {
                return BadRequest();
            }

            db.Entry(carDetails).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarDetailsExists(id))
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

        // POST: api/CarDetails
        [ResponseType(typeof(CarDetails))]
        public IHttpActionResult PostCarDetails(CarDetails carDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CarDetail.Add(carDetails);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carDetails.ID }, carDetails);
        }

        // DELETE: api/CarDetails/5
        [ResponseType(typeof(CarDetails))]
        public IHttpActionResult DeleteCarDetails(int id)
        {
            CarDetails carDetails = db.CarDetail.Find(id);
            if (carDetails == null)
            {
                return NotFound();
            }

            db.CarDetail.Remove(carDetails);
            db.SaveChanges();

            return Ok(carDetails);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarDetailsExists(int id)
        {
            return db.CarDetail.Count(e => e.ID == id) > 0;
        }
    }
}