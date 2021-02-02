using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Delegation.Models;
using Delegation.Models.Repositories;
using Delegation.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Delegation.Controllers
{
    public class ManageBusinessTripController : Controller
    {
        IBusinessTripRepository _repository;
        
        public ManageBusinessTripController(IBusinessTripRepository repository)
            => _repository = repository;

        public ViewResult Index() => View(_repository.BusinessTrips);

        public ViewResult Edit(int businessTripID)
            => View(new ManageBusinessTripViewModel
            {
                BusinessTrip = _repository.BusinessTrips
                    .FirstOrDefault(t => t.BusinessTripID == businessTripID),
                Drivers = GetSelectList(_repository.BusinessTrips
                    .Select(d => d.Driver)
                    .Distinct()
                    .OrderBy(d => d.EmployeeID))
            });

        private IEnumerable<SelectListItem> GetSelectList(IEnumerable<Driver> drivers)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            foreach(var d in drivers)
            {
                items.Add(new SelectListItem { Text = d.ToString(), Value = d.ToString() });
            }
            return items;
        }
    }
}
