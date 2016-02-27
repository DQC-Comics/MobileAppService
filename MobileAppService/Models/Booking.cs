using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileAppService.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public string HeroName { get; set; }

        public string Description { get; set; }

        public DateTimeOffset? StartTime { get; set; }

        public DateTimeOffset? EndTime { get; set; }
    }

    public class BookingUser
    {
        public string UserId { get; set; }
    }

    public class BookingNew : Booking
    {
        public string UserId { get; set; }
    }
}
