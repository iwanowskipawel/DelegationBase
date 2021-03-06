﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Delegation.Models
{
    [Serializable]
    public class KilometersCard
    {
        [Display(Name = "KilometerCardID")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int KilometersCardID { get; set; }

        [Display(Name = "Nr karty")]
        public string CardSymbol { get; set; }

        //[Display(Name = "Samochód", AutoGenerateField = true)]
        //public Car Car { get; set; }

        [Display(Name = "Karta pracy pojazdu")]
        public string WorkCardNumber { get; set; }

        //[Display(Name = "Wyjazdy", AutoGenerateField = true)]
        //public List<BusinessTrip> Trips { get; set; }

        //[Display(Name = "Przejechany dystans")]
        //public int TotalDistance => Trips.Sum(x => x.Distance);

        public override string ToString()
        {
            return CardSymbol;
        }
    }
}
