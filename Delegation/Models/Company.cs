using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using System.Text;

namespace Delegation.Models
{
    [Serializable]
    public class Company
    {
        [Display(Name = "CompanyID")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CompanyID { get; set; }

        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Adres")]
        public Address Address { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
