using System.Collections.Generic;

namespace Tracker.Models
{
  public class Orders
  {
    private static List<Orders> _instances = new List<Orders> {};
    public string Product {get; set;}
    public string Quantity {get; set;}
    public string Date {get; set;}
    public int Id {get;}

    public Orders (string product, string quantity, string date){
      // Product = product;
      Quantity = "";
      Date = date;
      // Id = _instances.Count;
      // _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();    
    }
  }
}