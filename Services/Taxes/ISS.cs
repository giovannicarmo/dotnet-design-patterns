namespace Dotnet.Design.Patterns.Services.Taxes
{
  public class ISS : Tax
  {
    public double Calculate(Budget budget)
    {
      return budget.Amount * 0.6;
    }
  }
}