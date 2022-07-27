using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class StudentRepoV2 : IRepo<Student, int>
    {
        public bool Create(Student obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> Get()
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
