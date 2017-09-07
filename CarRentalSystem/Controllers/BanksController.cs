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
    [RoutePrefix("api/banks")]
    public class BanksController : ApiController
    {
        private RentalDbContext db = new RentalDbContext();

        // GET: api/Banks
        public IQueryable<Banks> GetBank()
        {
            return db.Bank;
        }

        // GET: api/Banks/5
        [ResponseType(typeof(Banks))]
        public IHttpActionResult GetBanks(int id)
        {
            Banks banks = db.Bank.Find(id);
            if (banks == null)
            {
                return NotFound();
            }

            return Ok(banks);
        }

        // PUT: api/Banks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBanks(int id, Banks banks)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != banks.ID)
            {
                return BadRequest();
            }

            db.Entry(banks).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BanksExists(id))
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

        // POST: api/Banks
        [ResponseType(typeof(Banks))]
        public IHttpActionResult PostBanks(Banks banks)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Bank.Add(banks);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = banks.ID }, banks);
        }

        // DELETE: api/Banks/5
        [ResponseType(typeof(Banks))]
        public IHttpActionResult DeleteBanks(int id)
        {
            Banks banks = db.Bank.Find(id);
            if (banks == null)
            {
                return NotFound();
            }

            db.Bank.Remove(banks);
            db.SaveChanges();

            return Ok(banks);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BanksExists(int id)
        {
            return db.Bank.Count(e => e.ID == id) > 0;
        }
    }
}