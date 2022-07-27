using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class DepartmentRepo : IRepo<Department, int>
    {
        student_db_aEntities db;
        public DepartmentRepo(student_db_aEntities db)
        {
            this.db = db;
        }
        public bool Create(Department obj)
        {
            db.Departments.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public  List<Department> Get()
        {
            return db.Departments.ToList();
        }

        public  Department Get(int id)
        {
            return db.Departments.Find(id);
        }

        public bool Update(Department obj)
        {
            throw new NotImplementedException();
        }
    }
}
