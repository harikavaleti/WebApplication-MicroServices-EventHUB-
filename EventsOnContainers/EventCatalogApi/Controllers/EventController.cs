using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventCatalogApi.Data;
using EventCatalogApi.Domain;
using EventCatalogApi.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EventCatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {

        private readonly CatalogContext _context;
        private readonly IConfiguration _config;

        public EventController(CatalogContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Items([FromQuery]int pageIndex = 0, [FromQuery]int pageSize = 6)
        {
            var itemsCount = await _context.EventDetails.LongCountAsync();

            var items = await _context.EventDetails.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();

            items = ChangePictureUrl(items);

            var model = new PaginatedItemsViewModel<EventDetails>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Count = itemsCount,
                Data = items

            };

            return Ok(model);
        }

        private List<EventDetails> ChangePictureUrl(List<EventDetails> items)
        {
            items.ForEach(c => c.PictureUrl = c.PictureUrl.Replace("http://externalcatalogbaseurltobereplaced", _config["ExternalCatalogBaseUrl"]));
            return items;


        }

        [HttpGet]
        [Route("action")]
        public async Task<IActionResult> EventTypes()
        {
            var items = await _context.EventTypes.ToListAsync();
            return Ok(items);
        }


        [HttpGet]
        [Route("action")]
        public async Task<IActionResult> EventLocations()
        {
            var items = await _context.EventLocations.ToListAsync();
            return Ok(items);
        }

    }
}