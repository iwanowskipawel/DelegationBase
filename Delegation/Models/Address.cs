﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Delegation.Models
{
    [Serializable]
    public class Address
    {
        [Display(Name = "AddressID")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int AddressID { get; set; }

        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Display(Name = "Numer")]
        public string Number { get; set; }

        [Display(Name = "Miejscowość")]
        public string City { get; set; }

        [Display(Name = "Kod pocztowy")]
        public string PostalCode { get; set; }

        public override string ToString()
        {
            return $"{ Street } { Number }, { PostalCode } { City }";
        }
    }
}
