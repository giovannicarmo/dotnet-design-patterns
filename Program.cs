using Dotnet.Design.Patterns.Services.Taxes;
using Dotnet.Design.Patterns.Services;

namespace Dotnet.Design.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var icms = new ICMS();
            var iss = new ISS();
            var iccc = new ICCC();
            var budget = new Budget(5000);

            var taxCalculator = new TaxCalculator();

            taxCalculator.Perform(budget, icms);
            taxCalculator.Perform(budget, iss);
            taxCalculator.Perform(budget, iccc);
        }
    }
}
