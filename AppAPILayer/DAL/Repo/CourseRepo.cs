using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class CourseRepo : IRepo<Cours, int>
    {
        student_db_aEntities db;
        public CourseRepo(student_db_aEntities db)
        {
            this.db = db;
        }
        public bool Create(Cours obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cours> Get()
        {
            throw new NotImplementedException();
        }

        public Cours Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cours obj)
        {
            throw new NotImplementedException();
        }
    }
}
