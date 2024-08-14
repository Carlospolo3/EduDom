using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Domain.Entities
{
    public class Qualifications
    {
        public int Id { get; set; }
        public int Calification { get; set; }
        public int SubjectId { get; set; }
        public Subjects Subject { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }

}
