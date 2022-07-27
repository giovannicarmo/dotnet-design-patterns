using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Investments
{
  public class Conservative : Investment
  {
    public double Calculate(Budget budget)
    {
      return budget.Amount + (budget.Amount * 0.008);
    }
  }
}