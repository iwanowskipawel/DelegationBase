using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegation.Models.ViewModels
{
    public class ManageBusinessTripViewModel
    {
        public BusinessTrip BusinessTrip { get; set; }
        public string SelectedDriver { get; set; }
        public IEnumerable<SelectListItem> Drivers { get; set; }
        public string SelectedProject { get; set; }
        public IEnumerable<SelectListItem> Projects { get; set; }
    }
}
