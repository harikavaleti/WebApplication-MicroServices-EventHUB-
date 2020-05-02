using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Services;
using WebMVC.ViewModels;

namespace WebMVC.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _service;
        public EventController(IEventService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index(int? page, int? typesFilterApplied, int? locationFilterApplied)  
        
        {
            var itemsOnPage = 10;

            var events = await _service.GetEventItemsAsync(page ?? 0, itemsOnPage, typesFilterApplied, locationFilterApplied);
            var itemsonPage = (events.Count);

            itemsOnPage = (events.Count > itemsOnPage) ? itemsOnPage : int.Parse(itemsonPage.ToString());

            var vm = new EventIndexViewModel
            {
                CatalogItems = events.Data,
                PaginationInfo = new PaginationInfo 
                {
                    ActualPage = page ?? 0,
                    ItemsPerPage = itemsOnPage,
                    TotalItems = events.Count,
                    TotalPages = (int)Math.Ceiling((decimal)events.Count / itemsOnPage)

                },
                Location = await _service.GetLocationAsync(),
                Types = await _service.GetTypeAsync(),
                TypesFilterApplied = typesFilterApplied ?? 0,
                LocationFilterApplied = locationFilterApplied ?? 0
                
            };

            return View(vm);
        }
    }
}