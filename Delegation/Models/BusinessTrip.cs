using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Delegation.Models
{
    [Serializable]
    public class BusinessTrip
    {
        [Display(Name = "BusinessTripID")]
        public int BusinessTripID { get; set; }

        [Display(Name = "Wyjazd")]
        public DateTime DepartureDate { get; set; }

        [Display(Name = "Przyjazd")]
        public DateTime ArrivalDate { get; set; }

        [Display(Name = "Kierowca")]
        public Driver Driver { get; set; }

        [Display(Name = "Temat")]
        public Project Project { get; set; }

        [Display(Name = "Dysponent")]
        public Employee Keeper { get; set; }

        [Display(Name = "Miejsce docelowe")]
        public Destination Destination { get; set; }

        [Display(Name = "Samochód")]
        public Car Car { get; set; }

        [Display(Name = "Stan licznika początkowy")]
        public int InitialMeter { get; set; }

        [Display(Name = "Stan licznika końcowy")]
        public int FinalMeter { get; set; }

        [Display(Name = "Liczba przejechanych km")]
        public int Distance => FinalMeter - InitialMeter;

        public KilometersCard KilometersCard { get; set; }
    }
}
