using System;
using System.Collections.Generic;
using System.Text;

namespace WitSpeed.Models.Models
{
    public class Avatar: EntityBase
    {
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string Url { get; set; }
        public string PublicKey { get; set; }
    }
}
