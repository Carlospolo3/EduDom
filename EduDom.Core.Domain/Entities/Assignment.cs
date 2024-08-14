using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Domain.Entities
{
    public class Assignment
    {
      
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsSubmitted { get; set; }
        public double Score { get; set; }
        public double TotalPoints { get; set; }
        public int SubjectId { get; set; }
        public bool State { get; set; }
        public Subjects Subjects { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
