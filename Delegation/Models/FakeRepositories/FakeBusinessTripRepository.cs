using Delegation.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegation.Models.FakeRepositories
{
    public class FakeBusinessTripRepository : IBusinessTripRepository
    {
        public IQueryable<BusinessTrip> BusinessTrips => new List<BusinessTrip>
        {
            new BusinessTrip
            {
                DepartureDate = new DateTime(2020, 7, 13),
                ArrivalDate = new DateTime(2020, 7, 15),
                Driver = wieslaw,
                Destination = new Destination()
                {
                    Name = "Gdańsk"
                },
                InitialMeter = 353677,
                FinalMeter = 354456,
                Keeper = pawelI,
                Project = project1,
                KilometersCard = card1
            },
            new BusinessTrip
            {
                DepartureDate = new DateTime(2020, 7, 16),
                ArrivalDate = new DateTime(2020, 7, 17),
                Driver = wieslaw,
                Destination = new Destination()
                {
                    Name = "Kraków"
                },
                InitialMeter = 354456,
                FinalMeter = 355273,
                Keeper = pawelP,
                Project = project2,
                KilometersCard = card2
            },
            new BusinessTrip
            {
                DepartureDate = new DateTime(2020, 7, 22),
                ArrivalDate = new DateTime(2020, 7, 25),
                Driver = wieslaw,
                Destination = new Destination()
                {
                    Name = "Leźnica"
                },
                InitialMeter = 355273,
                FinalMeter = 355578,
                Keeper = pawelP,
                Project = project2,
                KilometersCard = card2
            }
        }.AsQueryable<BusinessTrip>();

        Driver wieslaw = new Driver()
        {
            FirstName = "Wiesław",
            LastName = "Eychler"
        };
        Employee pawelI = new Employee()
        {
            FirstName = "Paweł",
            LastName = "Iwanowski"
        };
        Employee pawelP = new Employee()
        {
            FirstName = "Paweł",
            LastName = "Pietruszewski"
        };

        Project project1 = new Project()
        {
            Symbol = "0-6541-24-1-00"
        };
        Project project2 = new Project()
        {
            Symbol = "0-6666-24-1-00"
        };
        
        Car car = new Car()
        {
            Model = "Ford Transit",
            RegistrationNumber = "WB 65788",
            //MainDriver = wieslaw,
            MeterStatus = 354456
        };

        KilometersCard card1 = new KilometersCard()
        {
            CardSymbol = "7/2020",
            WorkCardNumber = "456"
        };
        KilometersCard card2 = new KilometersCard()
        {
            CardSymbol = "8/2020",
            WorkCardNumber = "457"
        };
    }
}
