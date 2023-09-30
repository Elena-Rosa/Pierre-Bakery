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
  }
}
   