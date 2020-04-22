using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Models;

namespace WebMVC.Services
{
    public interface IEventService
    {
        Task<Event>GetEventItemsAsync(int page, int size);
        Task<IEnumerable<SelectListItem>> GetTypeAsync();
        Task<IEnumerable<SelectListItem>> GetLocationAsync();
    }
}
