using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Tracker.Models;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    Order testOrder;
    [TestInitialize]
    public void TestInitialize()
    {
      testOrder = new Order("Muffins");
    }
    [TestMethod]
    public void OrderConstructor_CreatesNewOrder_Order()
    {
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_StoresOrderDate_String()
    {
      string result = testOrder.Date;
      Assert.AreEqual("2/24/23", result);
    }
    [TestMethod]
    public void OrderConstructor_StoresOrderQuantity_String()
    {
      string result = testOrder.Quantity;
      Assert.AreEqual("1", result);
    }
    [TestMethod]
    public void OrderConstructor_StoresOrderProduct_String()
    {
      string result = testOrder.Product;
      Assert.AreEqual("Muffins", result);
    }
    [TestMethod]
    public void OrderConstructor_StoresOrderID_Int()
    {
      int result = testOrder.Id;
      Assert.AreEqual(0, result);
    }
    public void FindId_ReturnsORderById_int()
    {
     Assert.AreEqual(testOrder, Order.Find(1));
    }
    
  }
}