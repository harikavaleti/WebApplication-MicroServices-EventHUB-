using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebMVC.Models;
using WebMVC.Services;
using WebMVC.ViewModels;

namespace WebMVC.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _service;
        private readonly ILogger _logger;
        public EventController(IEventService service, ILoggerFactory logger)
        {
            _service = service;
            _logger = logger.CreateLogger<EventController>();
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

        public async Task<IActionResult> EventDetails(int eventId)
        {

            var eventDetails = await _service.GetEvent(eventId);

            var vm = new EventDetails
            {
                Id = eventId,
                Name = eventDetails.Name,
                Description = eventDetails.Description,
                Price = eventDetails.Price,
                Age = eventDetails.Age,
                Occupancy = eventDetails.Occupancy,
                PictureUrl = eventDetails.PictureUrl,
                Date = eventDetails.Date,
                Venue = eventDetails.Venue,
                EventLocation = eventDetails.EventLocation,
                EventType = eventDetails.EventType
            };

            return View(vm);
        }

        [Authorize]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page";
            return View();
        }

    }
}