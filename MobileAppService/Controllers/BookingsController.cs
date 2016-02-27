using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MobileAppService.Controllers
{
    using System.Threading.Tasks;
    using MobileAppService.Models;
    using DqccomicsMobileapiService;
    using DqccomicsMobileapiService.Models;
    using Microsoft.Azure.Mobile.Server.Config;

    [MobileAppController]
    public class BookingsController : ApiController
    {
        [Route("api/Bookings")]
        public async Task<IEnumerable<Booking>> PostBookings(BookingUser user)
        {
            var client = new Unknowntype();
            var bookings = await client.Bookings.GetBookingsWithOperationResponseAsync();
            return bookings.Body.Where(_ => _.CustomerId == user.UserId).Select(_ => new Booking
            {
                HeroName = _.Heroes.FirstOrDefault()?.Name ?? string.Empty,
                Description = _.Description,
                StartTime = _.StartTime,
                EndTime = _.EndTime
            });
        }

        [Route("api/Bookings/Create")]
        public async Task<Booking> PostCreate(BookingNew booking)
        {
            var client = new Unknowntype();

            var heroes = await client.Heroes.PostHeroesWithOperationResponseAsync(new ApiHeroSearch { StartTime = booking.StartTime, EndTime = booking.EndTime, Text = booking.Description });
            
            var hero = heroes.Body.FirstOrDefault();

            var apiBooking = new ApiBooking
                                 {
                                    Id = 0,
                                     CustomerId = booking.UserId,
                                     StartTime = booking.StartTime,
                                     EndTime = booking.EndTime,
                                     Description = booking.Description,
                                     Heroes = new List<ApiHeroBasic>() { new ApiHeroBasic() { Id = hero.Id, Name = hero.Name } },
                                     Location = string.Empty,
                                     City = string.Empty,
                                     Country = string.Empty,
                                     Status = string.Empty
                                 };

            try
            {
                var created = await client.Bookings.PostBookingWithOperationResponseAsync(apiBooking);
            }
            catch (Exception ex)
            {}

            return new Booking();
        }
    }
}
