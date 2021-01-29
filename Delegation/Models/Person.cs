using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Delegation.Models
{
    [Serializable]
    public abstract class Person
    {
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Display(Name = "Pełne nazwisko")]
        public string FullName => $"{ FirstName } { LastName }";

        public override string ToString()
        {
            return FullName;
        }
    }
}
