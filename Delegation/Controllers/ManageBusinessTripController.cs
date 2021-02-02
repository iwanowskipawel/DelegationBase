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
        IBusinessTripRepository _businessTripRepository;

        public ManageBusinessTripController(IBusinessTripRepository repository)
            => _businessTripRepository = repository;

        public ViewResult Index() => View(_businessTripRepository.BusinessTrips);
    }
}
