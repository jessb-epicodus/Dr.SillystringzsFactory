using System;
using System.Collections.Generic;

namespace Factory.Models {
  public class Machine {
    public Machine() {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public DateTime ProductionDate { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string SerialId { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}