using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegation.Models.ViewModels
{
    public class BusinessTripViewModel
    {
        public IEnumerable<BusinessTrip> BusinessTrips { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
