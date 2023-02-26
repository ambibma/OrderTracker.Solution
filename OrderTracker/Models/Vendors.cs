using System.Collections.Generic;

namespace Tracker.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public string Description {get; set;}
    public string Cost {get; set;}
    public int ID {get;}

    public List<Order> Orders {get; set;}
    private static List<Vendor> _instances = new List<Vendor>{};
  
    public Vendor (string name, string description, string cost, Order inputOrder){
      Name = name;
      // Description = description;
      // Cost = cost;      
      // ID = _instances.Count;
      // Information = inputOrder;
      // _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();    
    }
  }
}