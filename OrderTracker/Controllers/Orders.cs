using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tracker.Models;


namespace Tracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
       Vendor vendor = Vendor.Find(vendorId);
       return View(vendor);
    }
    // [HttpPost("/vendors/{vendorId}/orders")]
    // public ActionResult Create(int vendorId, string orderProduct, string orderQuantity, string orderDate)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Vendor foundVendor = Vendor.Find(vendorId);
    //   Order newOrder = new Order(orderProduct, orderQuantity, orderDate);
    //   foundVendor.AddOrder(newOrder);
    //   List<Order> vendorOrders = foundVendor.Orders;
    //   model.Add("orders", vendorOrders);
    //   model.Add("vendor", foundVendor);
    //   return View("Show", model);
    // }
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
    

  }
}