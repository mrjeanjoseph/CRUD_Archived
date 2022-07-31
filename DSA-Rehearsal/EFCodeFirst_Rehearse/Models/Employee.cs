using System;
using System.Collections.Generic;

#nullable disable

namespace EFCodeFirst_Rehearse.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int LocationId { get; set; }

        public virtual Location Location { get; set; }
    }
}
