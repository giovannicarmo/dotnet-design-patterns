using System.Collections.Generic;

namespace Dotnet.Design.Patterns.Domain
{
  public class Budget
  {
    public double Amount { get; set; }
    public IList<Item> Items { get; private set; }

    public Budget(double amount)
    {
      this.Amount = amount;
      this.Items = new List<Item>();
    }

    public void AddItems(Item item)
    {
      Items.Add(item);
    }
  }
}