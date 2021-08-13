using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WitSpeed.Models.Models
{
    public class Booking: EntityBase
    {
        public string DriverId { get; set; }
        public Driver Driver { get; set; }

        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string LocationAddress { get; set; }

        [Column(TypeName = "decimal(10, 6)")]
        public decimal LocationLat { get; set; }

        [Column(TypeName = "decimal(10, 6)")]
        public decimal LocationLng { get; set; }

        public string DestinationAddress { get; set; }

        [Column(TypeName = "decimal(10, 6)")]
        public decimal DestinationLat { get; set; }

        [Column(TypeName = "decimal(10, 6)")]
        public decimal DestinationLng { get; set; }

        public string TrackingNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpDeliveryDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateDelivered { get; set; }

        public bool Delivered { get; set; }
    }
}
