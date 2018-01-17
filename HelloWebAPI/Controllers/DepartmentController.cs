using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWebAPI.Models;

namespace HelloWebAPI.Controllers
{
    [RoutePrefix("api/department")]
    public class DepartmentController : ApiController
    {
        
        // GET: api/Department
        [HttpGet]
        //[Route("List")]
        public IEnumerable<Department> Get()
        {
            return new DepartmentRepository().GetAllDepartments();
        }

        //[HttpGet]
        //[Route("SpecialList")]
        //public IEnumerable<Department> GetSpecialDepartments()
        //{
        //    return new DepartmentRepository().GetAllDepartments().Where(d => d.Budget > 300).ToList();
        //}

        // GET: api/Department/5
        public HttpResponseMessage GetDepartment(int id)
        {
            var department = new DepartmentRepository().GetAllDepartments().Where(d => d.Id == id).FirstOrDefault();
            if (department != null)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, department);
                return response;
            }
            else
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.NotFound);
                return response;
            }
        }

        // POST: api/Department
        [HttpPost]
        public HttpResponseMessage SaveDepartment([FromBody]Department dep)
        {
            if (string.IsNullOrEmpty(dep.Name))
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest);
                return response;
            }
            else
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
                return response;
            }
        }

        // PUT: api/Department/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Department/5
        public void Delete(int id)
        {
        }
    }
}
