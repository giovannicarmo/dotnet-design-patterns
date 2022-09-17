using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Investments
{
  public class Conservative : IInvestment
  {
    public double Calculate(Account account)
    {
      return account.Amount + (account.Amount * 0.008);
    }
  }
}