using System;
using Dotnet.Design.Patterns.Domain;
using Dotnet.Design.Patterns.Services.Investments;

namespace Dotnet.Design.Patterns.Services
{
    public class InvestimentPerformer
    {
        public void Perform(Account account, IInvestment investiment)
        {
            var result = investiment.Calculate(account);
            Console.WriteLine($"{investiment.ToString()}: {result}");
        }
    }
}