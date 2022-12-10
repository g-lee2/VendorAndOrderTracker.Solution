using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void GetDate_ReturnsDate_Double()
    {
      double date = 4.11;

      Order newOrder = new Order("title", "description", 0.10, date);
      double result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_SetDate_Double()
    {
      double date = 3.01;
      Order newOrder = new Order("title", "description", 0.10, date);

      
      double updatedDate = 5.10;
      newOrder.Date = updatedDate;
      double result = newOrder.Date;

      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string title = "title1";
      string description = "description1";
      double price = 0.10;
      double date = 10.11;
      Order newOrder = new Order(title, description, price, date);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Category()
    {
      string title01 = "title1";
      string description01 = "description1";
      double price01 = 0.10;
      double date01 = 10.11;
      string title02 = "title2";
      string description02 = "description2";
      double price02 = 4.10;
      double date02 = 4.11;
      Order newOrder = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      string title01 = "title1";
      string description01 = "description1";
      double price01 = 0.10;
      double date01 = 10.11;
      string title02 = "title2";
      string description02 = "description2";
      double price02 = 4.10;
      double date02 = 4.11;
      Order newOrder = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);

      List<Order> newList = new List<Order> { newOrder, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}

