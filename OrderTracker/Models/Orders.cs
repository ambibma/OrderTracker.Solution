using System.Collections.Generic;

namespace Tracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Product {get; set;}
    public string Quantity {get; set;}
    public string Date {get; set;}
    public int Id {get;}

    public Order (string product){
      Product = product;
      Quantity = Quantity;
      Date = Date;
      Id = _instances.Count;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();    
    }
    // public static Order Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }
  }
}