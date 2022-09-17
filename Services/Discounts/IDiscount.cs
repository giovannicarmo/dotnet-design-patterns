using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Discounts
{
  public interface IDiscount
  {
    public IDiscount Next { get; set; }
    double Discounts(Budget budget);
  }
}