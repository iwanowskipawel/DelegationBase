using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using System.Linq;
using Delegation.Models.Repositories;
using Delegation.Controllers;
using Delegation.Models;
using Delegation.Models.ViewModels;

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
            BusinessTripViewModel firstPageResult =
                controller.List(null, 1).ViewData.Model as BusinessTripViewModel;
            BusinessTripViewModel secondPageResult =
                controller.List(null, 2).ViewData.Model as BusinessTripViewModel;

            //Assert
            BusinessTrip[] firstPageTripsArray = firstPageResult.BusinessTrips.ToArray();
            BusinessTrip[] secondPageTripsArray = secondPageResult.BusinessTrips.ToArray();

            Assert.True(firstPageTripsArray.Length == 10);
            Assert.True(secondPageTripsArray.Length == 1);

            Assert.Equal("d1", firstPageTripsArray[0].Destination.Name);
            Assert.Equal("d10", firstPageTripsArray[9].Destination.Name);
            Assert.Equal("d11", secondPageTripsArray[0].Destination.Name);
        }

        [Fact]
        public void CanSendPaginationViewModel()
        {
            //Arrange
            Mock<IBusinessTripRepository> mock = new Mock<IBusinessTripRepository>();
            mock.Setup(t => t.BusinessTrips).Returns(new BusinessTrip[]
            {
                new BusinessTrip{BusinessTripID = 1, Destination = new Destination{Name="d1"}},
                new BusinessTrip{BusinessTripID = 2, Destination = new Destination{Name="d2"}},
                new BusinessTrip{BusinessTripID = 3, Destination = new Destination{Name="d3"}},
                new BusinessTrip{BusinessTripID = 4, Destination = new Destination{Name="d4"}},
                new BusinessTrip{BusinessTripID = 5, Destination = new Destination{Name="d5"}}
            }.AsQueryable());

            BusinessTripController controller = new BusinessTripController(mock.Object);

            //Act
            BusinessTripViewModel result = controller.List(null, 2).ViewData.Model as BusinessTripViewModel;

            //Assert
            PagingInfo pagingInfo = result.PagingInfo;

            Assert.Equal(2, pagingInfo.CurrentPage);
            Assert.Equal(2, pagingInfo.ItemsPerPage);
            Assert.Equal(5, pagingInfo.TotalItems);
            Assert.Equal(3, pagingInfo.TotalPages);
        }
    }
}
