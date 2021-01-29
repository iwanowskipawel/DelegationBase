using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Delegation.Models
{
    [Serializable]
    public class Car
    {
        [Display(Name = "CarID")]
        public int CarID { get; set; }

        [Display(Name = "Model")]
        public string Model { get; set; }

        [Display(Name = "Numer rejestracyjny")]
        public string RegistrationNumber { get; set; }

        [Display(Name = "Główny kierowca")]
        public Driver MainDriver { get; set; }

        [Display(Name = "Stan licznika")]
        public int MeterStatus { get; set; }

        [Display(Name = "Karty przejechanych km")]
        public List<KilometersCard> KilometersCards { get; set; }

        public override string ToString()
        {
            return $"{ Model } { RegistrationNumber }";
        }
    }
}
