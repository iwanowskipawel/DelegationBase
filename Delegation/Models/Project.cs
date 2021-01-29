using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Delegation.Models
{
    [Serializable]
    public class Project
    {
        [Display(Name = "ProjectID")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }

        [Display(Name = "Symbol")]
        public string Symbol { get; set; }

        [Display(Name = "Firma")]
        public Company Company { get; set; }

        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        //[Display(Name = "Wyjazdy")]
        //public List<BusinessTrip> Trips { get; set; }

        public override string ToString() => Symbol;
    }
}
