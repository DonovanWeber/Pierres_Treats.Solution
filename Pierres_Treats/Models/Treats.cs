namespace PierresTreats.Models
{
    public class Treats
    {
      public Treat()
      {
      this.JoinEntities = new HashSet<FlavorTreat>(); 
      } 
    

    public int TreatId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}