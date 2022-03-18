using System.Collections.Generic;

namespace Factory.Models {
  public class Engineer {
    public Engineer() {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }
    public string Company { get; set; }
    public string PrimaryRep { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Hours { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}