using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("vendor", "sells pastry");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "London Pastry";

      Vendor newVendor = new Vendor(vendorName, "sells pastry");
      string result = newVendor.VendorName;

      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void SetVendorName_SetVendorName_String()
    {
      string vendorName = "London Pastry";
      Vendor newVendor = new Vendor(vendorName, "sells pastry");

      
      string updatedVendorName = "New Pastry";
      newVendor.VendorName = updatedVendorName;
      string result = newVendor.VendorName;

      Assert.AreEqual(updatedVendorName, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "London Pastry sells british and french pastry";

      Vendor newVendor = new Vendor("London Pastry", description);
      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "London Pastry sells british and french pastry";
      Vendor newVendor = new Vendor("London Pastry", description);

      
      string updatedDescription = "London Pastry sells scones";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetId_VendorsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string vendorName = "Pastry Shop";
      string description = "Sells asian pastry";
      Vendor newVendor = new Vendor(vendorName, description);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }
  }
}
