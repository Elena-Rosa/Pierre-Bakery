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
    public void VendorConstructor_SetsPropertiesCorrectly_Vendor()
    {
      Vendor newVendor = new Vendor ("Mia", "Market");
      Assert.AreEqual("Mia", newVendor.Name);
      Assert.AreEqual("Market", newVendor.Description);
    }
    [TestMethod]
    public void OrderConstructor_SetName_String()
     {
         Vendor newVendor = new Vendor ("Mia", "Market");
        newVendor.Name = "Library";
        Assert.AreEqual("Library", newVendor.Name);
    }
  
  }
}