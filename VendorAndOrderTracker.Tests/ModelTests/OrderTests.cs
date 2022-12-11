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
      Order newOrder = new Order("title", "description", 0.00, 4, 30, 2000);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "LP Order";

      Order newOrder = new Order(title, "description", 0.00, 4, 30, 2000);
      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "title";
      Order newOrder = new Order(title, "description", 0.00, 4, 30, 2000);

      
      string updatedTitle = "New title";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "description";

      Order newOrder = new Order("title", description, 0.00, 4, 30, 2000);
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string title = "title";
      Order newOrder = new Order(title, "description", 0.00, 4, 30, 2000);

      
      string updatedDescription = "New Description";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Double()
    {
      double price = 400.01;

      Order newOrder = new Order("title", "description", price, 4, 30, 2000);
      double result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Double()
    {
      double price = 400.01;
      Order newOrder = new Order("title", "description", price, 4, 30, 2000);

      
      double updatedPrice = 350.10;
      newOrder.Price = updatedPrice;
      double result = newOrder.Price;

      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetDate_ReturnsMonth_Int()
    {
      int month = 4;

      Order newOrder = new Order("title", "description", 0.10, month, 31, 2000);
      int result = newOrder.Month;

      Assert.AreEqual(month, result);
    }

    [TestMethod]
    public void SetDate_SetDate_Int()
    {
      int month = 3;
      Order newOrder = new Order("title", "description", 0.10, month, 31, 2000);

      
      int updatedMonth = 5;
      newOrder.Month = updatedMonth;
      int result = newOrder.Month;

      Assert.AreEqual(updatedMonth, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string title = "title1";
      string description = "description1";
      double price = 0.10;
      int month = 10;
      int day = 22;
      int year = 2022;
      Order newOrder = new Order(title, description, price, month, day, year);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Category()
    {
      string title01 = "title1";
      string description01 = "description1";
      double price01 = 0.10;
      int month01 = 10;
      int day01 = 31;
      int year01 = 2000;
      string title02 = "title2";
      string description02 = "description2";
      double price02 = 4.10;
      int month02 = 4;
      int day02 = 31;
      int year02 = 2000;
      Order newOrder = new Order(title01, description01, price01, month01, day01, year01);
      Order newOrder2 = new Order(title02, description02, price02, month02, day02, year02);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      string title01 = "title1";
      string description01 = "description1";
      double price01 = 0.10;
      int month01 = 10;
      int day01 = 31;
      int year01 = 2000;
      string title02 = "title2";
      string description02 = "description2";
      double price02 = 4.10;
      int month02 = 4;
      int day02 = 31;
      int year02 = 2000;
      Order newOrder = new Order(title01, description01, price01, month01, day01, year01);
      Order newOrder2 = new Order(title02, description02, price02, month02, day02, year02);

      List<Order> newList = new List<Order> { newOrder, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}

