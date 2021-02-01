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
                new BusinessTrip {BusinessTripID = 1, Project = new Project { ProjectID = 1 } },
                new BusinessTrip {BusinessTripID = 2, Project = new Project { ProjectID = 3 } },
                new BusinessTrip {BusinessTripID = 3, Project = new Project { ProjectID = 1 } },
                new BusinessTrip {BusinessTripID = 4, Project = new Project { ProjectID = 2 } }
                }).AsQueryable<BusinessTrip>());
           
            NavigationMenuViewComponent target = new NavigationMenuViewComponent(mock.Object);
            
            // Act
            int[] results = ((IEnumerable<int>)(target.Invoke()
            as ViewViewComponentResult).ViewData.Model).ToArray();

            // Assert
            Assert.True(Enumerable.SequenceEqual(new int[] { 1, 2, 3 }, results));
        }
    }
}
