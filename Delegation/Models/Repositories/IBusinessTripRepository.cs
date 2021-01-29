using System.Collections.Generic;
using System.Linq;

namespace Delegation.Models.Repositories
{
    public interface IBusinessTripRepository
    {
        IQueryable<BusinessTrip> BusinessTrips { get; }
    }
}