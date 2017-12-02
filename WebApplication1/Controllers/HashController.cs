using Plugin.Security.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/hash")]
    public class HashController : ApiController
    {
        [HttpGet]
        [Route("GetHash")]
        public IHttpActionResult GetHash(string email,string password)
        {
            try
            {
                var hash = new PasswordEncoder();
                var salt = hash.DefaultSalt[2];

                var crypt = hash.Encode(salt + email + password);

                return Ok(crypt);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
