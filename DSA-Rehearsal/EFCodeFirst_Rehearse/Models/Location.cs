using System;
using System.Collections.Generic;

#nullable disable

namespace EFCodeFirst_Rehearse.Models
{
    public partial class Location
    {
        public Location()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string LocationCode { get; set; }
        public string LocationDesc { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
