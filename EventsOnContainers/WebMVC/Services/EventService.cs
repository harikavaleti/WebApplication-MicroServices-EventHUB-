using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Infrastructure;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class EventService : IEventService
    {
        private readonly string _baseUri;
        private readonly IHttpClient _client;
        public EventService(IConfiguration config, IHttpClient client)
        {
            _baseUri = $"{config["EventCatalogUrl"]}/api/event/";
            _client = client;
        }
        public async Task<Event> GetEventItemsAsync(int page, int size)
        {

           var eventItemsUri = ApiPaths.Catalog.GetAllCatalogItems(_baseUri, page, size);

           string datastring = await _client.GetStringAsync(eventItemsUri);

            return JsonConvert.DeserializeObject<Event>(datastring);

        }

        public async Task<IEnumerable<SelectListItem>> GetLocationAsync()
        {
           var locationUri =  ApiPaths.Catalog.GetAllLocations(_baseUri);
           var datastring = await _client.GetStringAsync(locationUri);
            var items = new List<SelectListItem>
           {
               new SelectListItem
               {
                   Value = null,
                   Text = "All",
                   Selected = true
               }
           };

            var locations = JArray.Parse(datastring);
            foreach(var location in locations)
            {
                items.Add(new SelectListItem
                {
                    Value = location.Value<string>("id"),
                    Text = location.Value<string>("location")
                });
            }
            return items;
        }

        public async Task<IEnumerable<SelectListItem>> GetTypeAsync()
        {
            var typeUri = ApiPaths.Catalog.GetAllTypes(_baseUri);
            var datastring = await _client.GetStringAsync(typeUri);
            var items = new List<SelectListItem>
            {
                new SelectListItem
                {
                   Value = null,
                   Text = "All",
                   Selected = true
                }
            };

            var types = JArray.Parse(datastring);
            foreach(var type in types)
            {
                items.Add(new SelectListItem
                {
                    Value = type.Value<string>("id"),
                    Text = type.Value<string>("type")
                });
            }
            return items;
        }
    }
}
