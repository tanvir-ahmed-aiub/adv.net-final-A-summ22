using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static student_db_aEntities db = new student_db_aEntities();
        public static IRepo<Department,int>  DepartmentDataAccess()
        {
            return new DepartmentRepo(db);
        }
        public static IRepo<Cours, int> CourseDataAccess() {
            return new CourseRepo(db);
        }
        public static IRepo<Student, int> StudentDataAccess() {
            return new StudentRepoV2();
        }
    }
}
