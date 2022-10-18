using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Taxes
{
  public abstract class AbstractConditionalTax : Tax
  {
    public abstract bool HasToUseMaxTax(Budget budget);
    public abstract double CalculateMaxTax(Budget budget);
    public abstract double CalculateMinTax(Budget budget);
    public double Calculate(Budget budget)
    {
      if(HasToUseMaxTax(budget))
      {
        return CalculateMaxTax(budget);
      }
      else
      {
        return CalculateMinTax(budget);
      }
    }
  }
}