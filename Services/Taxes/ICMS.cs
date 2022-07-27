namespace Dotnet.Design.Patterns.Services.Taxes
{
  public class ICMS : Tax
  {
    public double Calculate(Budget budget)
    {
      return budget.Amount * 0.1;
    }
  }
}