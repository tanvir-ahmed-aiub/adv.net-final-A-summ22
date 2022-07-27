using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StudentRepo:IRepo<Student,int>
    {
        student_db_aEntities db;
        public StudentRepo(student_db_aEntities db) {
            this.db = db;
        }
        public  List<Student> Get()
        {
            return db.Students.ToList();
        }
        public  Student Get(int id)
        {
            return db.Students.FirstOrDefault(s => s.Id == id);
        }
        public  bool Create(Student s)
        {
            db.Students.Add(s);
            var rs = db.SaveChanges();
            if (rs > 0) return true;
            return false;

        }
        public  bool Delete(int id)
        {
            var st = Get(id);
            db.Students.Remove(st);
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public bool Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
