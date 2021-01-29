using Delegation.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegation.Models.DataAccess
{
    public class EFBusinessTripRepository : IBusinessTripRepository
    {
        private ApplicationDbContext _context;

        public EFBusinessTripRepository(ApplicationDbContext context) => _context = context;

        public IQueryable<BusinessTrip> BusinessTrips => _context.BusinessTrips;
    }
}
