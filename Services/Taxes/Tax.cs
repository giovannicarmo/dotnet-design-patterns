using Dotnet.Design.Patterns.Domain;

namespace Dotnet.Design.Patterns.Services.Taxes
{
    public interface Tax
    {
        double Calculate(Budget budget);
    }
}