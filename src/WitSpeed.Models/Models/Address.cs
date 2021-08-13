using System;
using System.Collections.Generic;
using System.Text;

namespace WitSpeed.Models.Models
{
    public class Address: EntityBase
    {
        public string FullAddress { get; set; }
        public string State { get; set; }
        public string LGA { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
