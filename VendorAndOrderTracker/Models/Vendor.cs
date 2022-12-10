using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    private static List<Order> _instances = new List<Order> {};
    public string VendorName { get; set; }
    public string Description { get; set; }
    public int Id { get; }

    public Vendor(string vendorName, string description)
    {
      VendorName = vendorName;
      Description = description;
      _instances.Add(this);
    }
  }
}

