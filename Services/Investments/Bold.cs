using System;
using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Investments
{
  public class Bold : Investment
  {
    public double Calculate(Budget budget)
    {
      double profit;
      var probability = new Random().Next(101);

      if (probability > 50)
      {
        profit = 0.006;
      }
      else
      {
        if (probability > 30)
        {
          profit = 0.03;
        }
        else
        {
          profit = 0.05;
        }
      }

      return budget.Amount + (budget.Amount * profit);
    }
  }
}