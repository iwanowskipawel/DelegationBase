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
        public int PageSize = 2;

        public BusinessTripController(IBusinessTripRepository repository)
        {
            _repository = repository;
        }
        //public ViewResult List() 
        //    => View(_repository.BusinessTrips);

        public ViewResult List(int page = 1) 
            => View(_repository.BusinessTrips
            .OrderBy(t => t.BusinessTripID)
            .Skip((page - 1) * PageSize)
            .Take(PageSize));
    }
}
