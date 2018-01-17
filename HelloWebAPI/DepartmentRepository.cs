using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloWebAPI.Models;

namespace HelloWebAPI
{
    public class DepartmentRepository
    {
        public IEnumerable<Department> GetAllDepartments()
        {

            return new List<Department>()
            {
                new Department() {Id = 1, Name = "Tom", Budget = 5000},
                new Department() {Id = 2, Name = "Tom", Budget = 5000},
                new Department() {Id = 3, Name = "Tom", Budget = 5000},
            };
        }
    }
}