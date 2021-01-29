using DelegationLibrary.Model;
using System.Collections.Generic;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface IBusinessTripRepository
    {
        IQueryable<BusinessTrip> BusinessTrip { get; }
    }
}