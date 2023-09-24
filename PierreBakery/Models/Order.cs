using System.Collections.Generic;
using System;

namespace PierreBakery.Models;

  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public int Price { get; set; }
  public Order (string title, string description, string date, int price)
  {
    Title = title;
    Description = description;
    Date = date;
    Price = price;
  }
  }
  