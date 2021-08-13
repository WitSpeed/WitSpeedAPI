using System;
using System.Collections.Generic;
using System.Text;

namespace WitSpeed.Models.Models
{
    public class Customer: EntityBase
    {
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Review> Reviews { get; set; }


        public Customer()
        {
            Bookings = new HashSet<Booking>();
            Ratings = new HashSet<Rating>();
            Reviews = new HashSet<Review>();
        }
    }
}
