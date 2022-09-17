using Dotnet.Design.Patterns.Domain;
using Dotnet.Design.Patterns.Services.Discounts;

namespace Dotnet.Design.Patterns.Services
{
  public class DiscountCalculator
  {
    public double Perform(Budget budget)
    {
      var d1 = new FiveItemsDiscount();
      var d2 = new AmountMoreThanFiveHunredsDiscount();
      var d3 = new SpecialDiscount();
      var d4 = new WithoutDiscount();

      d1.Next = d2;
      d2.Next = d3;
      d3.Next = d4;

      return d1.Discounts(budget);
    }
  }
}