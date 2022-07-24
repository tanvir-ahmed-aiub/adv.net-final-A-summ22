using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Cgpa { get; set; }
    }
}
