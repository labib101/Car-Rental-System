using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarRentalSystem.Models;

namespace CarRentalSystem.Controllers
{
    [RoutePrefix("api/default")]
    public class DefaultController : ApiController
    {
        public RentalDbContext ctx = new RentalDbContext();

        public IList<LoginAuthentication> get()
        {
            return ctx.Auth.ToList();
        }
        public string post(LoginAuthentication auth)
        {
            string email = auth.Email.ToString();
            LoginAuthentication Usercheck = ctx.Auth.SingleOrDefault(d => d.Email == email);
            if (Usercheck != null)
            {
                if (Usercheck.Password == auth.Password)
                {
                    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                    string resp = Usercheck.AuthToken.ToString();
                    return resp;
                }
                else
                {
                    string resp = "error matching pass";
                    return resp;
                    //return Request.CreateResponse(HttpStatusCode.Forbidden); 
                }
            }
            else
            {
                string resp = "error login";
                return resp;
                //return Request.CreateResponse(HttpStatusCode.Forbidden); 
            }
        }
    }
}
