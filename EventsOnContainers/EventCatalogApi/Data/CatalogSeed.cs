using Microsoft.EntityFrameworkCore;
using EventCatalogApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventCatalogApi.Data;

namespace EventCatalogApi.Data
{
    public static class CatalogSeed
    {
        public static void Seed(CatalogContext context)
        {
            context.Database.Migrate();
           
            if (!context.EventTypes.Any())
            {
                context.EventTypes.AddRange(GetPreConfiguredEventTypes());
                context.SaveChanges();
            }

            if (!context.EventLocations.Any())
            {
                context.EventLocations.AddRange(GetPreConfiguredEventLocations());
                context.SaveChanges();
            }


            if (!context.EventDetails.Any())
            {
                context.EventDetails.AddRange(GetPreConfiguredEventDetails());
                context.SaveChanges();
            }


        }

        private static IEnumerable<EventType> GetPreConfiguredEventTypes()
        {
            return new List<EventType>
            {
                new EventType {Type = "Entertainment"},
                new EventType {Type = "Culture & Education"},
                new EventType {Type = "Social"},
                new EventType {Type = "Sports & Fitness"},
                new EventType {Type = "Tech Conference"},
                new EventType {Type = "Business & Career"}
            };

        }

        private static IEnumerable<EventLocation> GetPreConfiguredEventLocations()
        {
            return new List<EventLocation>
            {
                new EventLocation {Location = "Bellevue"},
                new EventLocation {Location = "Redmond"},
                new EventLocation {Location = "Renton"},
                new EventLocation {Location = "Seattle"},
                new EventLocation {Location = "Sammamish"},
                new EventLocation {Location = "LynnWood"},
                new EventLocation {Location = "Kirkland"},
                new EventLocation {Location = "Woodinville"},
                new EventLocation {Location = "Anacortes"},
                new EventLocation {Location = "Everett"},
            };

        }
        private static IEnumerable<EventDetails> GetPreConfiguredEventDetails()
        {
            return new List<EventDetails>()
            {


                new EventDetails { EventTypeId=1, EventLocationId=2, Description = "Vocal concert by Ranjani & Gayatri", Name = "Vocal Concert", Price = 19, Venue="Redmond High School,17272 Northeast 104th Street,Redmond, WA 98052", Occupancy=200, Age="Above 8", Date="May 9, 5PM",PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/1" },
                new EventDetails { EventTypeId=1, EventLocationId=7, Description = "Join us for a wonderful evening evening with Jennifer Mellish Jazz Quartet!", Name = "Jennifer Mellish Jazz concert", Price= 35, Age="Above 15", Date="May 12, 7PM", Occupancy=250, Venue="Stage 7 Pianos,12037 124th Avenue Northeast,Kirkland, WA 98034", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/2" },
                new EventDetails { EventTypeId=1, EventLocationId=4, Description = "Playback Theater Northwest: True Stories on Stage", Name = "Playback Theater Northwest", Price = 25, Age = "Above 6", Date= "May 4, 7PM", Occupancy=150, Venue="Seattle Asian Medicine and Martial Arts,12025 Lake City Way NE, STE B,Seattle, WA 98125 ",PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/3" },
                new EventDetails { EventTypeId=1, EventLocationId=3, Description = "Come celebrate local singer-songwriter, Frances Hope’s first EP Release!", Name = "Frances Hope EP Release Party", Price = 20, Age="Above 10", Date="May 9, 7PM", Occupancy=125, Venue="High Dive Renton, Renton, WA",PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/4" },
                new EventDetails { EventTypeId=6, EventLocationId=1, Description = "Giving & Receiving Feedback Skills for Supervisors", Name = "Giving & Receiving Feedback Skills for Supervisors", Price = 80, Age="Above 15", Occupancy=100, Date="May 25, 4PM", Venue="Bellevue College, Bellevue", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/5" },
                new EventDetails { EventTypeId=2, EventLocationId=5, Description = "Come join us for a friendly night of cultural immersion! Dinner and entertainment are provided.", Name = "Culture Night", Price = 50, Age="Above 16", Occupancy=150, Date="May 18, 7PM", Venue="801 228th Ave SE,. Sammamish, WA 98075",PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/6" },
                new EventDetails { EventTypeId=6, EventLocationId=4, Description = "Career Event for College Students- ALL MAJORS Certificate, Associate or Bachelor Degree Programs", Name = "Career Event for U of WASHINGTON Students", Price = 10, Age="Above 18", Occupancy=100, Date="May 18, 4PM", Venue="U WASHINGTON College Students,TBD,Seattle, WA", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/7"  },
                new EventDetails { EventTypeId=2, EventLocationId=4, Description = "Your company's culture is 8x's more influential than strategy in determining performance. We'll teach you to build a one page culture plan.", Name = "How To Build A Culture People Want to Work In", Price = 70, Age="Above 18", Occupancy=125, Date="May 30, 4PM", Venue="The 2100 Building,2100 24th Avenue South,Seattle, WA 98144", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/8" },
                new EventDetails { EventTypeId=3, EventLocationId=4, Description = "GoGreen Conference - Seattle 2020", Name = "GoGreen Conference", Price = 25, Age="Above 15", Occupancy=100, Date="June 1, 5PM", Venue="Hyatt Regency Seattle | 3rd Floor - Columbia Ballroom,808 Howell Street,Seattle, WA 98101", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/9" },
                new EventDetails { EventTypeId=3, EventLocationId=6, Description = "The Business at The Funhouse", Name = "The Business at The Funhouse", Price = 30, Age="Above 21", Occupancy=100, Date="June 3, 7PM", Venue="Funhouse,109 Eastlake Ave E,LynnWood" ,PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/10" },
                new EventDetails { EventTypeId=3, EventLocationId=7, Description = "Concept of beefsteak originated in NY as a blue collar dinner meant to have people in large groups eat with reckless abandon. ", Name = "Beefsteak Night", Price = 25, Age="Above 18", Occupancy=75, Date="May 7, 7PM", Venue="Stage 7 Pianos,12037 124th Avenue Northeast,Kirkland, WA 98034" ,PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/11" },
                new EventDetails { EventTypeId=3, EventLocationId=9, Description = "Why do I attract the same partners and make the same mistakes? How do I let go of uncertainty, anger, and bitterness? How do I draw firm boundaries with myself and others?", Name = "Show Me The Love 2020", Price = 45, Age="Above 20", Occupancy=100, Date="May 10, 6PM", Venue="100 Commercial Ave, Anacortes, WA 98221" ,PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/12" },
                new EventDetails { EventTypeId=4, EventLocationId=8, Description = "Run 2 Be Fit", Name = "Run or Wine 5k", Price = 20, Age="Above 10", Occupancy=200, Date="May 16, 7AM", Venue="Woodinville, WA",PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/13" },
                new EventDetails { EventTypeId=4, EventLocationId=10, Description = "Art of snowshoeing while enjoying the majestic beauty of winter.", Name = "Guided Snowshoe Trip ", Price = 30, Age="Above 8", Occupancy=35, Date="May 3, 8AM", Venue="Verlocal,Redmond, WA 98052, United States, 16421 Cleveland St Ste B,Everett, WA 98052", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/14" },
                new EventDetails { EventTypeId=4, EventLocationId=1, Description ="Under the Lights is the exclusive youth flag football partner of Under Armour, Inc. The league is for both boys and girls of all skill level", Name = "Under The Lights Flag Football ", Price = 99, Age="Above 10", Occupancy=150, Date="May 19, 5PM", Venue="Bellevue College,3000 Landerholm Circle Southeast,Bellevue, WA 98007", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/15" },
                new EventDetails { EventTypeId=4, EventLocationId=1, Description ="The Virtual Run Challenge paying tribute to these soldiers we are introducing our first annual Memorial Day Virtual Running event.", Name = "Remember the Fallen Virtual 21K Run Walk", Price = 25, Age="Above 10", Occupancy=100, Date="May 29, 11AM", Venue="Bellevue,YOUR CHOICE,Bellevue, WA 98004", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/16" },
                new EventDetails { EventTypeId=5, EventLocationId=2, Description ="At Kal Academy, our next cohort of classes is starting soon. Come hear us talk about the program and get your questions answered!", Name = "Kal Academy Information Session", Price = 0, Age="Above 20", Occupancy=50, Date="May 17, 11AM", Venue="2757 152nd Ave NE,2757 152nd Avenue Northeast,Redmond, WA 98052", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/17" },
                new EventDetails { EventTypeId=5, EventLocationId=3, Description ="Tech is awesome. Tech people are terrible. But you’re afraid to tell them how awful they are, because you think they have deadly robot crows", Name = "Socially Inept: Tech Roast Show", Price = 35, Age="Above 20", Occupancy=100, Date="June 7,5PM", Venue="Hale's Ales Palladium,4301 Leary Way NW,Renton, WA 98107", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/18" },
                new EventDetails { EventTypeId=5, EventLocationId=2, Description ="Develop a Successful Healthcare Tech Startup Business Today! Medical - Digital Health -Hackathon - Virtual - Webinar", Name = "Develop a Successful Healthcare Tech Startup Business Today!", Price = 20, Age="Above 21", Occupancy=100, Date="June 15, 11AM", Venue="Seattle,Virtual Workshop,Seattle, WA", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/19" },
                new EventDetails { EventTypeId=5, EventLocationId=10, Description ="Get the inside scoop from top Product People before The Product Management Conference kick-off, followed by the exclusive VIP dinner.", Name = "ProductCon Seattle", Price = 30, Age="Above 20", Occupancy=100, Date="June 29, 12AM", Venue="TBC,Everett, WA 98121", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/20" }

            };
        }

       


    }
}
