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

            var items = await _context.EventDetails.OrderBy(c => c.Name).Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();

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

        [HttpGet]
        [Route("[action]/type/{eventTypeId}/location/{eventLocationId}")]
        public async Task<IActionResult> Items(int? eventTypeId, 
                                                 int? eventLocationId, 
                                                [FromQuery]int pageIndex = 0,
                                                [FromQuery]int pageSize = 6)
        {
            var root = (IQueryable<EventDetails>)_context.EventDetails;
            if (eventTypeId.HasValue)
            {
                root = root.Where(c => c.EventTypeId == eventTypeId || eventTypeId == -1);
            }
            if (eventLocationId.HasValue)
            {
                root = root.Where(c => c.EventLocationId == eventLocationId || eventLocationId == -1);
            }
            var itemsCount = await root.LongCountAsync();
            var items = await root.OrderBy(c => c.Name).Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
            items = ChangePictureUrl(items);
            var model = new PaginatedItemsViewModel<EventDetails>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Data = items,
                Count = itemsCount
            };
            return Ok(model);
        }

        private List<EventDetails> ChangePictureUrl(List<EventDetails> items)
        {
            items.ForEach(c => c.PictureUrl = c.PictureUrl.Replace("http://externalcatalogbaseurltobereplaced", _config["ExternalCatalogBaseUrl"]));
            return items;


        }

        [HttpGet]
        [Route("[action]/{eventId}")]
        public async Task<IActionResult> GetEvent(int eventId)
        {
            if(eventId <= 0)
            {
                return BadRequest();
            }
            var item = await _context.EventDetails.SingleOrDefaultAsync(c => c.Id == eventId);

            if(item != null)
            {
                item.PictureUrl = item.PictureUrl.Replace("http://externalcatalogbaseurltobereplaced", _config["ExternalCatalogBaseUrl"]);
                return Ok(item);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> EventTypes()
        {
            var items = await _context.EventTypes.ToListAsync();
            return Ok(items);
        }


        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> EventLocations()
        {
            var items = await _context.EventLocations.ToListAsync();
            return Ok(items);
        }

    }
}