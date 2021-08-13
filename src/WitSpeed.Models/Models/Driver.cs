using System;
using System.Collections.Generic;
using System.Text;

namespace WitSpeed.Models.Models
{
    public class Driver: EntityBase
    {
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public string DispatchToolId { get; set; }
        public DispatchTool DispatchTool { get; set; }

        public string IdType { get; set; }
        public string IdNumber { get; set; }
        public string IdPhotoUrl { get; set; }
        public string IdPhotoPublicKey { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Review> Reviews { get; set; }


        public Driver()
        {
            Bookings = new HashSet<Booking>();
            Ratings = new HashSet<Rating>();
            Reviews = new HashSet<Review>();
        }
    }
}
