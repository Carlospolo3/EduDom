using EduDom.Core.Aplication.ViewModels.Estudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Domain.Entities
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StudentViewModels> Students { get; set; }
    }

}
