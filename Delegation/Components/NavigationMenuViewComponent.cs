using Delegation.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegation.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBusinessTripRepository _repository;

        public NavigationMenuViewComponent(IBusinessTripRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke() 
            => View(_repository.BusinessTrips
                .Select(t=>t.Project.Symbol)
                .Distinct()
                .OrderBy(t=>t));
    }
}
