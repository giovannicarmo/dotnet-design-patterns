using Dotnet.Design.Patterns.Domain;
using Dotnet.Design.Patterns.Services;
using Dotnet.Design.Patterns.Services.Investments;
using Dotnet.Design.Patterns.Services.Taxes;

namespace Dotnet.Design.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var conservative = new Conservative();
            var moderate = new Moderate();
            var bold = new Bold();

            var budget = new Budget(100_000);
            var calculator = new InvestimentPerformer();

            calculator.Perform(budget, conservative);
            calculator.Perform(budget, moderate);
            calculator.Perform(budget, bold);
        }
    }
}
