using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Investments
{
    public interface Investment
    {
        public double Calculate(Account account);
    }
}