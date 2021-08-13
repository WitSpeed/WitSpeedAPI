using System;
using System.Collections.Generic;
using System.Text;

namespace WitSpeed.Models.Models
{
    public class Rating: EntityBase
    {
        public string DriverId { get; set; }
        public Driver Driver { get; set; }
        
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int Rate { get; set; }
    }
}
