using System.Collections.Generic;
using System;

namespace Pierre.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.JoinEntities = new HashSet<FlavorTreat>();
        }

        public int FlavorId { get; set; }
        public string FlavorName { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<FlavorTreat> JoinEntities { get;}
    }
}