using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Delegation.Models
{
    [Serializable]
    public class Employee : Person
    {
        [Display(Name = "EmployeeID")]
        public int EmployeeID { get; set; }

        //[Display(Name = "Wyjazdy")]
        //public List<BusinessTrip> Trips { get; set; }

    }
}
