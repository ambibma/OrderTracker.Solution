using System.Collections.Generic;

namespace Tracker.Models
{
  public class Orders
  {
    public string Product {get; set;}
    public string Quantity {get; set;}
    public string Date {get; set;}
    public int ID {get;}
    private int _rollingCounter = new int();

    public Orders (string product, string quantity, string date){
      Product = product;
      Quantity = quantity;
      Date = date;
      _rollingCounter++;
      ID = _rollingCounter;
    }
  }
}