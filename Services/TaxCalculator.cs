using System;
using Dotnet.Design.Patterns.Domain;
using Dotnet.Design.Patterns.Services.Taxes;

namespace Dotnet.Design.Patterns.Services
{
    public class TaxCalculator
    {
        public void Perform(Budget budget, Tax tax)
        {
            var result = tax.Calculate(budget);
            Console.WriteLine($"{tax.ToString()}: {result}");
        }
    }
}