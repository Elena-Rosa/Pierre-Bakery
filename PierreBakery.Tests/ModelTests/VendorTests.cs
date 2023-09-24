using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreBakery.Models;
using System;

namespace PierreBakery.Tests
{
  [TestClass]
  public class VendorTests 
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Mia", "Mia");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      Vendor newVendor = new Vendor("Bowls", "Bowls");
     
      List<Vendor> newList = new List<Vendor> { };

      CollectionAssert.AreEqual(newList, Vendor.GetAll());
    }
    [TestMethod]
    public void SetNameProperty_SetsNameProperty()
    {
      Vendor newVendor = new Vendor("test", "test");
      string newName = "Cupcake";
      newVendor.Name = newName;
      string result = newVendor.Name;
      Assert.AreEqual(newName, result);
    }
    [TestMethod]
    public void SetDescriptionProperty_SetsDescriptionProperty()
    {
      Vendor newVendor = new Vendor("purple", "purple");
      string newDescription = "Purple";
      newVendor.Description = newDescription;
      string result = newVendor.Description;
      Assert.AreEqual(newDescription, result);
    }
  }
}
