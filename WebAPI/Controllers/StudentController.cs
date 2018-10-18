using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class StudentController : ApiController
    {
        public static List<Student> studentList = new List<Student>() {
            new Student(01,"Tony"),
            new Student(02,"Bob")
        };
        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            return studentList.ToList();
        }

        // GET: api/Student/5
        public Student Get(int id)
        {
            return studentList.Where(st => st.StudentId == id).Single();
        }

        // POST: api/Student
        public HttpResponseMessage Post([FromBody]Student student)
        {
            HttpResponseMessage response;
            try
            {
                studentList.Add(student);
                response = Request.CreateResponse(HttpStatusCode.OK, "Student added successfully");
                return response;
            }
            catch (Exception ex)
            {
                return response = Request.CreateResponse(HttpStatusCode.BadRequest, "Unable to add student");                 
            }
        }

        // PUT: api/Student/5
        public HttpResponseMessage Put(int id, [FromBody]Student student)
        {
            HttpResponseMessage response;
            try
            {
                studentList.Remove(studentList.Where(st => st.StudentId == id).Single());
                studentList.Add(student);
                response = Request.CreateResponse(HttpStatusCode.OK, "Student updated successfully");
                return response;
            }
            catch (Exception ex)
            {
                return response = Request.CreateResponse(HttpStatusCode.BadRequest, "Unable to update student");
            }
            
        }

        // DELETE: api/Student/5
        public HttpResponseMessage Delete(int id)
        {
            HttpResponseMessage response;
            try
            {
                studentList.Remove(studentList.Where(st => st.StudentId == id).Single());
                response = Request.CreateResponse(HttpStatusCode.OK, "Student deleted successfully");
                return response;
            }
            catch (Exception ex)
            {
                return response = Request.CreateResponse(HttpStatusCode.BadRequest, "Unable to delete student");
            }
        }
    }
}
