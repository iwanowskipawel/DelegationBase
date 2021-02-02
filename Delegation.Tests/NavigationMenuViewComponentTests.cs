using System.Collections.Generic;
using System.Linq;
using Delegation.Components;
using Delegation.Models;
using Delegation.Models.Repositories;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Moq;
using Xunit;


namespace Delegation.Tests
{
    public class NavigationMenuViewComponentTests
    {
        [Fact]
        public void Can_Select_Categories()
        {
            // Arrange
            Mock<IBusinessTripRepository> mock = new Mock<IBusinessTripRepository>();
            mock.Setup(m => m.BusinessTrips).Returns((new BusinessTrip[] {
                new BusinessTrip {BusinessTripID = 1, Project = new Project { Symbol = "1" } },
                new BusinessTrip {BusinessTripID = 2, Project = new Project { Symbol = "2" } },
                new BusinessTrip {BusinessTripID = 3, Project = new Project { Symbol = "1" } },
                new BusinessTrip {BusinessTripID = 4, Project = new Project { Symbol = "1" } }
                }).AsQueryable());
           
            NavigationMenuViewComponent target = new NavigationMenuViewComponent(mock.Object);
            
            // Act
            string[] results = ((IEnumerable<string>)(target.Invoke()
            as ViewViewComponentResult).ViewData.Model).ToArray();

            // Assert
            Assert.True(Enumerable.SequenceEqual(new string[] { "1", "2" }, results));
        }
    }
}
