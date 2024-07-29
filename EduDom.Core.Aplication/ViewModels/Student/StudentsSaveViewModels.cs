﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.ViewModels.Estudent
{
    public class StudentSaveViewModels
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int CourseId { get; set; }
    }

}
