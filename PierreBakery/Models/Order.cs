using System.Collections.Generic;
using System;

namespace PierreBakery.Models
  {

  public class Order
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public int Price { get; set; }
    private static List<Order> _instances = new List<Order> { };

  public Order (string title, string description, string date, int price)
  {
    Title = title;
    Description = description;
    Date = date;
    Price = price;
     _instances.Add(this);
      Id = _instances.Count;
  }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
  