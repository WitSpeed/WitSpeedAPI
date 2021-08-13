using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WitSpeed.Models.Models
{
    public class VehicleType: EntityBase
    {
        [Column(TypeName = "VARCHAR(25)")]
        public string TypeName { get; set; }
    }
}
