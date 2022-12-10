using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
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

