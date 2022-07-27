using System;
using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Investments
{
  public class Bold : Investment
  {
    public double Calculate(Account account)
    {
      double profit;
      var probability = new Random().Next(10);

      if (probability < 2)
      {
        profit = 0.05;
      } else if (probability >= 2 && probability <= 4)
      {
          profit = 0.03;
      } else
      {
        profit = 0.006;
      }

      return account.Amount + (account.Amount * profit);
    }
  }
}