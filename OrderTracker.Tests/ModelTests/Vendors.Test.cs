using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System;

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
      testVendor = new Vendor("Smith", "Smith's Coffee", "2/24/23", testOrder);
      testOrder = new Order("Muffins", "1", "2/24/23");
    }
    [TestMethod]
    public void VendorConstructor_CreatesNewVendor_Vendor()
    {
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
    
    
  }
}