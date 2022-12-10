using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description", 0.00, 4.11);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "LP Order";

      Order newOrder = new Order(title, "description", 0.00, 4.11);
      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "title";
      Order newOrder = new Order(title, "description", 0.00, 4.11);

      
      string updatedTitle = "New title";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "description";

      Order newOrder = new Order("title", description, 0.00, 4.11);
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string title = "title";
      Order newOrder = new Order(title, "description", 0.00, 4.11);

      
      string updatedDescription = "New Description";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Double()
    {
      double price = 400.01;

      Order newOrder = new Order("title", "description", price, 4.11);
      double result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Double()
    {
      double price = 400.01;
      Order newOrder = new Order("title", "description", price, 4.11);

      
      double updatedPrice = 350.10;
      newOrder.Price = updatedPrice;
      double result = newOrder.Price;

      Assert.AreEqual(updatedPrice, result);
    }
  }
}
