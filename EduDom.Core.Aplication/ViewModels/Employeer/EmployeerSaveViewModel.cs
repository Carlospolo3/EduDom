﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.ViewModels.Employeer
{
    public class EmployeerSaveViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DepartmentId { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string IdentificationNumber { get; set; }
    }

}
