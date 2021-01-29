using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DelegationLibrary.Model
{
    [Serializable]
    public class Destination
    {
        [Display(Name = "DestinationID")]
        public int DestinationID { get; set; }

        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Adres")]
        public Address Address { get; set; }

        [Display(Name = "Wyjazdy")]
        public List<BusinessTrip> Trips { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
