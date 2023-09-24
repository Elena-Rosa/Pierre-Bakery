using System.Collections.Generic;
using System;

namespace PierreBakery.Models;

  public class Vendor
  
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public static List <Order> Orders { get; set; }
   public Vendor (string name, string description)
   {
     Name = name;
     Description = description;
     Orders = new List<Order> {};
   }
   public static List<Order> GetAll()
   {
     return Orders;
   }
   
  }
