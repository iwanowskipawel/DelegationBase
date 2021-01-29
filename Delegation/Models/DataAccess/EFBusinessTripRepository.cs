using Delegation.Models.Repositories;
using Microsoft.EntityFrameworkCore;
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

        public IQueryable<BusinessTrip> BusinessTrips 
            => _context.BusinessTrips
            .Include(t=>t.Project)
            .Include(t=>t.KilometersCard)
            .Include(t=>t.Keeper)
            .Include(t=>t.Car)
            .Include(t=>t.Destination)
            .Include(t=>t.Driver);
    }
}
