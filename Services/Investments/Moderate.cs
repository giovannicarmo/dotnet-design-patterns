using System;
using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Investments
{
  public class Moderate : Investment
  {
    public double Calculate(Account account)
    {
      return account.Amount + (account.Amount * (new Random().Next(2) == 0 ? 0.025 : 0.007));
    }
  }
}