using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.ViewModels.Qualifications
{
    public class QualificationsSaveViewModels
    {
        public int Id { get; set; }
        public int Calification { get; set; }
        public string Subject { get; set; }
        public int StudentId { get; set; }
    }

}
