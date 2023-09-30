using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreBakery.Models;
using System;

namespace PierreBakery.Tests
{
  [TestClass]
  public class OrderTests 
  {

   [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order ("Dry Goods", "Flour", "2024-09-24", 10);
        Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_SetsPropertiesCorrectly_Order()
    {
      Order newOrder = new Order ("Dry Goods", "Flour", "2024-09-24", 10);
      Assert.AreEqual("Dry Goods", newOrder.Title);
      Assert.AreEqual("Flour", newOrder.Description);
      Assert.AreEqual("2024-09-24", newOrder.Date);
      Assert.AreEqual(10, newOrder.Price);
    }
  }
}

    