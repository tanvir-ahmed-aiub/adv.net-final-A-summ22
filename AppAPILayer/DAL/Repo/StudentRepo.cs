using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StudentRepo
    {
        static student_db_aEntities db = new student_db_aEntities();
        public static List<Student> Get()
        {
            return db.Students.ToList();
        }
        public static Student Get(int id)
        {
            return db.Students.FirstOrDefault(s => s.Id == id);
        }
        public static bool Create(Student s)
        {
            db.Students.Add(s);
            var rs = db.SaveChanges();
            if (rs > 0) return true;
            return false;

        }
        public static bool Edit(Student s)
        {
            var st = Get(s.Id);
            db.Entry(st).CurrentValues.SetValues(s);
            var rs = db.SaveChanges();
            return rs > 0;  

        }
        public static bool Delete(int id)
        {
            var st = Get(id);
            db.Students.Remove(st);
            var rs = db.SaveChanges();
            return rs > 0;
        }



    }
}
