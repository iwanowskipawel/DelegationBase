﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using System.Linq;
using Delegation.Models.Repositories;
using Delegation.Controllers;
using Delegation.Models;

namespace Delegation.Tests
{
    public class BusinessTripControllerTests
    {
        [Fact]
        public void CanPaginate()
        {
            //Arrange
            Mock<IBusinessTripRepository> mock = new Mock<IBusinessTripRepository>();

            mock.Setup(t => t.BusinessTrips).Returns((new BusinessTrip[] {
                new BusinessTrip{BusinessTripID=1, Destination = new Destination{Name="d1"}},
                new BusinessTrip{BusinessTripID=2, Destination = new Destination{Name="d2"}},
                new BusinessTrip{BusinessTripID=3, Destination = new Destination{Name="d3"}},
                new BusinessTrip{BusinessTripID=4, Destination = new Destination{Name="d4"}},
                new BusinessTrip{BusinessTripID=5, Destination = new Destination{Name="d5"}},
                new BusinessTrip{BusinessTripID=6, Destination = new Destination{Name="d6"}},
                new BusinessTrip{BusinessTripID=7, Destination = new Destination{Name="d7"}},
                new BusinessTrip{BusinessTripID=8, Destination = new Destination{Name="d8"}},
                new BusinessTrip{BusinessTripID=9, Destination = new Destination{Name="d9"}},
                new BusinessTrip{BusinessTripID=10, Destination = new Destination{Name="d10"}},
                new BusinessTrip{BusinessTripID=11, Destination = new Destination{Name="d11"}}
            }).AsQueryable<BusinessTrip>());

            BusinessTripController controller = new BusinessTripController(mock.Object);
            controller.PageSize = 10;

            //Act
            IEnumerable<BusinessTrip> firstPageResult =
                controller.List(1).ViewData.Model as IEnumerable<BusinessTrip>;
            IEnumerable<BusinessTrip> secondPageResult =
                controller.List(2).ViewData.Model as IEnumerable<BusinessTrip>;

            //Assert
            BusinessTrip[] firstPageTripsArray = firstPageResult.ToArray();
            BusinessTrip[] secondPageTripsArray = secondPageResult.ToArray();

            Assert.True(firstPageTripsArray.Length == 10);
            Assert.True(secondPageTripsArray.Length == 1);

            Assert.Equal("d1", firstPageTripsArray[0].Destination.Name);
            Assert.Equal("d10", firstPageTripsArray[9].Destination.Name);
            Assert.Equal("d11", secondPageTripsArray[0].Destination.Name);
        }
    }
}