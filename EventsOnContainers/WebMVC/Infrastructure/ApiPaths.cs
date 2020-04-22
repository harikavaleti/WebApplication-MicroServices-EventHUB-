using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Infrastructure
{
    public class ApiPaths
    {
        public static class Catalog
        {   
            public static string GetAllCatalogItems(string baseUri, int page, int take)
            {
                return $"{baseUri}items?pageIndex={page}&pageSize={take}";
            }
            public static string GetAllTypes(string baseUri)
            {
                return $"{baseUri}catalogtypes";
            }
            public static string GetAllLocations(string baseUri)
            {
                return $"{baseUri}cataloglocations";
            }

        }
        public static class Basket
        {

<<<<<<< Updated upstream
            
=======
            public static string GetAllCatalogItems(string baseUri, int page, int take)
            {
                return $"{baseUri}items?pageIndex={page}&pageSize={take}";
            }
>>>>>>> Stashed changes
        }
    }
}
