using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WitSpeed.Models.Models
{
    public class Review: EntityBase
    {
        public string DriverId { get; set; }
        public Driver Driver { get; set; }

        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string Content { get; set; }
    }
}
