using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Taxes
{
  public class ICCC : Tax
  {
    public double Calculate(Budget budget)
    {
      var amount = budget.Amount;

      if (amount < 1_000)
      {
        return amount * 0.05;
      }
      else if (amount >= 1_000 && amount <= 3_000)
      {
        return amount * 0.07;
      }
      else
      {
        return (amount * 0.08) + 30;
      }
    }
  }
}