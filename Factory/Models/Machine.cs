using System;
using System.Collections.Generic;

namespace Factory.Models {
  public class Machine {
    public Machine() {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public DateTime Date { get; set; }
    public string MakeModel { get; set; }
    public string SerialId { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}