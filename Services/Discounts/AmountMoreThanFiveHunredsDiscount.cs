using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Discounts
{
  public class AmountMoreThanFiveHunredsDiscount : IDiscount
  {
    public IDiscount Next { get; set; }
    public double Discounts(Budget budget)
    {
      if (budget.Amount > 500)
      {
        return budget.Amount * 0.07;
      }
      else
      {
        return Next.Discounts(budget);
      }
    }
  }
}