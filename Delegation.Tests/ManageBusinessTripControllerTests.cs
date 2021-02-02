using Delegation.Controllers;
using Delegation.Models;
using Delegation.Models.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Delegation.Tests
{
    public class ManageBusinessTripControllerTests
    {
        [Fact]
        public void IndexContainsAllTrips()
        {
            //Arrange
            Mock<IBusinessTripRepository> mock = new Mock<IBusinessTripRepository>();
            mock.Setup(t => t.BusinessTrips).Returns(new BusinessTrip[]
            {
                new BusinessTrip{BusinessTripID=1, Destination=new Destination{Name = "p1"}},
                new BusinessTrip{BusinessTripID=2, Destination=new Destination{Name = "p2"}},
                new BusinessTrip{BusinessTripID=3, Destination=new Destination{Name = "p3"}},
                new BusinessTrip{BusinessTripID=4, Destination=new Destination{Name = "p4"}}
            }.AsQueryable());

            ManageBusinessTripController controller = new ManageBusinessTripController(mock.Object);

            //Act
            BusinessTrip[] result = (controller.Index().ViewData.Model as IEnumerable<BusinessTrip>).ToArray();

            //Assert
            Assert.Equal(1, result[0].BusinessTripID);
            Assert.Equal(2, result[1].BusinessTripID);
            Assert.Equal(3, result[2].BusinessTripID);
            Assert.Equal(4, result[3].BusinessTripID);
            Assert.Equal(4, result.Length);
        }
    }
}
