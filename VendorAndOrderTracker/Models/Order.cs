using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public double Date { get; set; }
    public int Id { get; }
    public Order(string title, string description, double price, double date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }
  }
}
