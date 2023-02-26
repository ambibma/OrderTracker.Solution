using System.Collections.Generic;

namespace Tracker.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public string Description {get; set;}
    public int Id {get;}

    public List<Order> Orders {get; set;}
    private static List<Vendor> _instances = new List<Vendor>{};
  
    public Vendor (string name, string description){
      Name = name;
      Description = description;
      // Cost = cost;      
      Id = _instances.Count;
      // Information = inputOrder;
      // _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();    
    }
  }
}