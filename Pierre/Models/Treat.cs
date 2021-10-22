using System.Collections.Generic;
using System.Linq;

namespace Pierre.Models
{
  public class Treat
    {
        public Treat()
        {
            this.JoinEntities = new HashSet<FlavorTreat>();
        }

        public int TreatId { get; set; }
        public string TreatName { get; set; }
        public string TreatDescription { get; set; }
        public int Inventory { get; set; }
        public int TreatPrice { get; set; }
        public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
    }
}