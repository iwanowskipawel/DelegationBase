using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Delegation.Models
{
    [Serializable]
    public class Driver : Employee
    {
        [Display(Name = "DriverID")]
        public int DriverID { get; set; }

        [Display(Name = "Użytkowane samochody")]
        public List<Car> UsedCars { get; set; }
    }
}
