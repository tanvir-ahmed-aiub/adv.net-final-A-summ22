using BLL.Entities;
using DAL;
using DAL.EF;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        public static List<StudentModel> Get()
        {
            var data = DataAccessFactory.StudentDataAccess().Get();
            var students = new List<StudentModel>();
            foreach (var item in data)
            {
                var s = new StudentModel() { 
                    Id = item.Id,
                    Name = item.Name,
                    Dob = item.Dob,
                    Cgpa = item.Cgpa
                };
                students.Add(s);
            }
            return students;
        }
        public static List<Student> GetScholarshipData()
        {
            return DataAccessFactory.StudentDataAccess().Get().Where(s => s.Cgpa.Equals("3.75")).ToList();//cgpa was string thats why equal oprtr used 
        }
        public static List<Student>GetVar(int num)
        {
            return DataAccessFactory.StudentDataAccess().Get().Take(num).ToList();
        }
        public static StudentModel Get(int id)
        {
            var item= DataAccessFactory.StudentDataAccess().Get(id);
            var s = new StudentModel()
            {
                Id = item.Id,
                Name = item.Name,
                Dob = item.Dob,
                Cgpa = item.Cgpa
            };

            return s;
        }
        public static bool Create(StudentModel s)
        {
            
            var student = new Student();
            student.Id = s.Id;
            student.Name = s.Name;
            student.Dob = s.Dob;
            student.Cgpa = s.Cgpa;          
            return DataAccessFactory.StudentDataAccess().Create(student);
        }
    }
}
