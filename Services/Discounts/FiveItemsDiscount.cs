using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Discounts
{
  public class FiveItemsDiscount : IDiscount
  {
    public IDiscount Next { get; set; }

    public double Discounts(Budget budget)
    {
      if (budget.Items.Count > 5)
      {
        return budget.Amount * 0.1;
      }
      else
      {
        return Next.Discounts(budget);
      }
    }
  }
}