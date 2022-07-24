using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroWEBAPI.Controllers
{
    public class PersonController : ApiController
    {

        public string Get() {
            return "Get method Called";
        }
        public string Post() {
            return "Post method Called";
        }
        public string Put()
        {
            return "Put method Called";
        }
        public string Delete()
        {
            return "Post method Called";
        }

    }
}
