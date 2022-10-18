using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Taxes
{
    public class IKCV : AbstractConditionalTax
    {
        public override bool HasToUseMaxTax(Budget budget)
        {
            return budget.Amount >= 500 && HasItemMoreThanOneHundred(budget);
        }
        public override double CalculateMaxTax(Budget budget)
        {
            return budget.Amount * 0.1;
        }
        public override double CalculateMinTax(Budget budget)
        {
            return budget.Amount * 0.06;
        }

        private bool HasItemMoreThanOneHundred(Budget budget)
        {
            foreach (Item item in budget.Items)
            {
                if (item.Price > 100) return true;
            }
            return false;
        }
    }
}