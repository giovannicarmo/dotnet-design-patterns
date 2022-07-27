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

            var account = new Account();
            account.Deposit(100_000);
            var calculator = new InvestimentPerformer();

            calculator.Perform(account, conservative);
            calculator.Perform(account, moderate);
            calculator.Perform(account, bold);
        }
    }
}
