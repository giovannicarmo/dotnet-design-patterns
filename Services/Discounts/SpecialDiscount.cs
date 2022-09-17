using System;
using System.Linq;
using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Discounts
{
  public class SpecialDiscount : IDiscount
  {
    public IDiscount Next { get; set; }

    public double Discounts(Budget budget)
    {
      if (budget.Items.Where(i =>
            i.Name.ToUpper().Equals("PEN") || i.Name.ToUpper().Equals("PENCIL")).Any()
        )
      {
        return budget.Amount * 0.05;
      }
      else
      {
        return Next.Discounts(budget);
      }
    }
  }
}