using System;
using Dotnet.Design.Patterns.Domain;
using Dotnet.Design.Patterns.Services.Investments;

namespace Dotnet.Design.Patterns.Services
{
    public class InvestimentPerformer
    {
        public void Perform(Budget budget, Investment investiment)
        {
            var result = investiment.Calculate(budget);
            Console.WriteLine($"{investiment.ToString()}: {result}");
        }
    }
}