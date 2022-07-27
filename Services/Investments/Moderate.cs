using System;
using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Investments
{
  public class Moderate : Investment
  {
    public double Calculate(Budget budget)
    {
      return budget.Amount + (budget.Amount * (new Random().Next(101) > 50 ? 0.025 : 0.007));
    }
  }
}