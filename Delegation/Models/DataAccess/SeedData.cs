using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delegation.Models.FakeRepositories;

namespace Delegation.Models.DataAccess
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.BusinessTrips.Any())
            {
                FakeBusinessTripRepository fakeBusinessTripRepository = new FakeBusinessTripRepository();
                context.BusinessTrips.AddRange(fakeBusinessTripRepository.BusinessTrips);
            }

            context.SaveChanges();
        }
    }
}
