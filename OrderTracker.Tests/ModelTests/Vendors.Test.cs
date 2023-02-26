using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Tracker.Models;

namespace Tracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    Vendor testVendor;
    Order testOrder;
    [TestInitialize]
    public void TestInitialize()
    {
      testVendor = new Vendor("Smith", "Smith's Coffee");
      testOrder = new Order("Muffins","1","2/24/23");
    }
    [TestMethod]
    public void VendorConstructor_CreatesNewVendor_Vendor()
    {
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
    [TestMethod]
    public void VendorConstructor_StoresVendorName_String()
    {
      string result = testVendor.Name;
      Assert.AreEqual("Smith", result);
    }
    [TestMethod]
    public void VendorConstructor_StoresVendorDescription_String()
    {
      string result = testVendor.Description;
      Assert.AreEqual("Smith's Coffee", result);
    }
    [TestMethod]
    public void VendorConstructor_StoresVendorID_Int()
    {
      int result = testVendor.Id;
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void AddOrder_StoresOrdersInList_Int()
    {
     testVendor.AddOrder(testOrder);
     Assert.AreEqual(1, testVendor.Orders.Count);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendors_List()
    {
     Assert.AreEqual(1, Vendor.GetAll().Count);
    }
    [TestMethod]
    public void FindId_ReturnsVendorById_int()
    {
     Assert.AreEqual(testVendor, Vendor.Find(1));
    }
    
    
    
  }
}