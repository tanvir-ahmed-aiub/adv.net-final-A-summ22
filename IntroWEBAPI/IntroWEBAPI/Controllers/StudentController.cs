using IntroWEBAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroWEBAPI.Controllers
{
    public class StudentController : ApiController
    {
        [Route("api/student/all")]
        [HttpGet]
        public HttpResponseMessage AllStudent() {
            var db = new student_db_aEntities();
            var data = db.Students.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/student/{id}")]
        [HttpGet]
        public HttpResponseMessage GetStudent(int id) {
            var db = new student_db_aEntities();
            var s = db.Students.FirstOrDefault(x => x.Id == id);
            if (s == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound); 
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, s);
            }
        }
        [Route("api/student/create")]
        [HttpPost]
        public HttpResponseMessage CreateStudent(Student s) {
            var db = new student_db_aEntities();
            var st = db.Students.Add(s);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK,st);
        } 
    }   
}
