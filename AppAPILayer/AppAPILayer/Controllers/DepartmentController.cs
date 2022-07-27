using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AppAPILayer.Controllers
{
    [EnableCors("*","*","*")]
    public class DepartmentController : ApiController
    {
        [Route("api/department/all")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = DepartmentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/department/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = DepartmentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/department/{id}/students")]
        [HttpGet]
        public HttpResponseMessage GetDeptWithStudents(int id)
        {
            var data = DepartmentService.GetDeptWithStudent(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
