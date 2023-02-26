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

    public Order (string product, string quantity, string date){
      Product = product;
      Quantity = quantity;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();    
    }
    public static Order Find(int searchId)
    {
      return _instances [searchId - 1];
    }
  }
}