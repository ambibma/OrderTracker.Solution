using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tracker.Models;

namespace Tracker.Tests
{
  [TestClass]
  public class OrdersTests : IDisposable
  {
    public void Dispose()
    {
      Orders.ClearAll();
    }
    Orders testOrder;
    [TestInitialize]
    public void TestInitialize()
    {
      testOrder = new Orders("Muffins", "1", "2/24/23");
    }
    [TestMethod]
    public void OrderConstructor_CreatesNewOrder_Order()
    {
      Assert.AreEqual(typeof(Orders), testOrder.GetType());
    }
    [TestMethod]
    public void GetOrderDate_StoresOrderInfo_String()
    {
      string result = testOrder.Date;
      Assert.AreEqual("2/24/23", result);
    }
    [TestMethod]
    public void GetOrderQuantity_StoresOrderInfo_String()
    {
      string result = testOrder.Quantity;
      Assert.AreEqual("1", result);
    }
  }
}