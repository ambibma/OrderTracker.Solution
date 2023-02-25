using System.Collections.Generic;

namespace Tracker.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public string Description {get; set;}
    public string Cost {get; set;}
    public int ID {get;}
    private static int _rollingCounter = new Int();

    public Orders Information {get; set;}
    private static List<Vendor> _instances = new List<Vendor>{};
  
    public Vendor (string name, string description, string cost, Orders inputOrder){
      Name = name;
      Description = description;
      Cost = cost;
      _rollingCounter++;
      ID = _rollingCounter;
      Information = inputOrder;
      _instances.Add(this);
    }
  }
}