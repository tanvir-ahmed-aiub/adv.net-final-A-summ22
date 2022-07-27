using BLL.Entities;
using DAL;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DepartmentService
    {
        public static List<DepartmentModel> Get() {
            var data = DataAccessFactory.DepartmentDataAccess().Get();
            var depts = new List<DepartmentModel>();
            foreach (var item in data) {
                depts.Add(new DepartmentModel() { Id = item.Id, Name = item.Name });
            }
            return depts;   
        }
        public static DepartmentModel Get(int id) {
            var item = DataAccessFactory.DepartmentDataAccess().Get(id);
            var dept = new DepartmentModel() { Id = item.Id, Name = item.Name };
            return dept;
        }
        public static DepartmentStudentModel GetDeptWithStudent(int id) {
            var item = DataAccessFactory.DepartmentDataAccess().Get(id);
            var dept = new DepartmentStudentModel() { Id = item.Id, Name = item.Name };
            foreach (var student in item.Students) { 
                dept.Students.Add(new StudentModel() { Id = student.Id, Name = student.Name,Cgpa=student.Cgpa,Dob =student.Dob }); 
            }
            return dept;
        }
    }
}
