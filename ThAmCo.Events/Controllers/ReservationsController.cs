using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThAmCo.Events.Data;
using ThAmCo.Events.Services;
using ThAmCo.Events.Models;
using ThAmCo.Venues.Models;

namespace ThAmCo.Events.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly EventsDbContext _context;

        public ReservationsController(EventsDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            Event @event = await _context.Events.FindAsync(id);

            // GET: api/Availability?eventType=X?beginDate=X&endDate=X

            var venues = new List<AvailabilityGetDto>().AsEnumerable();

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:23652/");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
            client.Timeout = TimeSpan.FromSeconds(5);

            HttpResponseMessage response = await client.GetAsync(
                "/api/Availability?eventType=" + @event.TypeId
                + "&beginDate=" + @event.Date.ToString("yyyy/MM/dd")
                + "&endDate=" + @event.Date.ToString("yyyy/MM/dd")
            );

            if (response.IsSuccessStatusCode)
                venues = await response.Content.ReadAsAsync<IEnumerable<AvailabilityGetDto>>();
            else
                Debug.WriteLine("Index recieved a bad response from the web service.");

            return View(venues);
        }
    }
}
