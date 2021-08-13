using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WitSpeed.Models.Models
{
    public class DispatchTool: EntityBase
    {
        public string DriverId { get; set; }
        public Driver Driver { get; set; }

        public string VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Make { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Model { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public String Color { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string RegNumber { get; set; }
    }
}
