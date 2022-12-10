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

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendorName01 = "Pastry Shop";
      string vendorName02 = "London Pastry";
      string description01 = "Sells asian pastry";
      string description02 = "Sells English scones and pastry";
      Vendor newVendor1 = new Vendor(vendorName01, description01);
      Vendor newVendor2 = new Vendor(vendorName02, description02);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName01 = "Pastry Shop";
      string vendorName02 = "London Pastry";
      string description01 = "Sells asian pastry";
      string description02 = "Sells English scones and pastry";
      Vendor newVendor1 = new Vendor(vendorName01, description01);
      Vendor newVendor2 = new Vendor(vendorName02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string title01 = "title1";
      string description01 = "description1";
      double price01 = 0.10;
      double date01 = 10.11;
      Order newOrder = new Order(title01, description01, price01, date01);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "Pastry Shop";
      string description = "Sells asian pastry";
      Vendor newVendor = new Vendor(vendorName, description);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}
