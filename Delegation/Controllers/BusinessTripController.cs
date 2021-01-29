using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delegation.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Delegation.Controllers
{
    public class BusinessTripController : Controller
    {
        private IBusinessTripRepository _repository;

        public BusinessTripController(IBusinessTripRepository repository)
        {
            _repository = repository;
        }
        public ViewResult Index() => View(_repository.BusinessTrips);
    }
}
