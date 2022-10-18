using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Taxes
{
    public class ICPP : AbstractConditionalTax
    {
        public override bool HasToUseMaxTax(Budget budget)
        {
            return budget.Amount >= 500;
        }
        public override double CalculateMaxTax(Budget budget)    
        {
            return budget.Amount * 0.07;
        }
        public override double CalculateMinTax(Budget budget)
        {
            return budget.Amount * 0.05;
        }
  }
}