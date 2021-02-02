using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delegation.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Delegation.Controllers
{
    public class ManageBusinessTripController : Controller
    {
        IBusinessTripRepository _repository;

        public ManageBusinessTripController(IBusinessTripRepository repository)
            => _repository = repository;

        public ViewResult Index() => View(_repository.BusinessTrips);

        public ViewResult Edit(int businessTripID)
            => View(_repository.BusinessTrips
                .FirstOrDefault(t => t.BusinessTripID == businessTripID));
    }
}
