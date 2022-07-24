using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppAPILayer.Controllers
{
    public class StudentController : ApiController
    {
        [Route("api/student/get")]
        public HttpResponseMessage Get()
        {
            var data = StudentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data); 
        }
        [Route("api/student/create")]
        [HttpPost]
        public  HttpResponseMessage Create(StudentModel s)
        {
            StudentService.Create(s);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
