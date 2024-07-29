using EduDom.Core.Aplication.ViewModels.Estudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Domain.Entities
{
    public class RegistrationViewModel
    {
        public int Id { get; set; }
        public StudentViewModels Student { get; set; }
        public CourseViewModel Course { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

}
