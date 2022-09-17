using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Investments
{
    public interface IInvestment
    {
        public double Calculate(Account account);
    }
}