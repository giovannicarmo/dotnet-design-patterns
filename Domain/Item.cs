using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet.Design.Patterns.Domain
{
  public class Item
  {
    public string Name { get; private set; }
    public double Price { get; private set; }

    public Item(string name, double price)
    {
      this.Name = name;
      this.Price = price;
    }
  }
}