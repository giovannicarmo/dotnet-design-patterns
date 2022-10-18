using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Discounts
{
  public class WithoutDiscount : IDiscount
  {
    public IDiscount Next { get; set; }

    public double Discounts(Budget budget)
    {
      return 0;
    }
  }
}