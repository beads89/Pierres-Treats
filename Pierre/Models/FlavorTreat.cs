namespace Pierre.Models
{
  public class CustomerGame
    {
        public int FlavorTreatId { get; set; }
        public int FlavorId { get; set; }
        public int TreatId { get; set; }
        public virtual Flavor Flavor { get; set; }
        public virtual Treat Treat { get; set; }
    }
}
        // public bool Returned { get; set; }