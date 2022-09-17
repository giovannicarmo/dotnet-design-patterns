using System;
using System.Linq;
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

      //Statregy
      var iss = new ISS();
      var icms = new ICMS();
      var iccc = new ICCC();

      var taxCalculator = new TaxCalculator();

      var budget = new Budget(1_000);

      taxCalculator.Perform(budget, iss);
      taxCalculator.Perform(budget, icms);
      taxCalculator.Perform(budget, iccc);

      var conservative = new Conservative();
      var moderate = new Moderate();
      var bold = new Bold();

      var investmentCalculator = new InvestimentPerformer();

      var account = new Account();
      account.Deposit(100_000);

      investmentCalculator.Perform(account, conservative);
      investmentCalculator.Perform(account, moderate);
      investmentCalculator.Perform(account, bold);
      //end

      //Chain of Responsability
      var budget2 = new Budget(0);

      budget2.AddItems(new Item("Pen", 2.50));
      budget2.AddItems(new Item("Pencil", 2));
      budget2.AddItems(new Item("Freezer", 1200.81));
      budget2.AddItems(new Item("Stove", 789.90));
      budget2.AddItems(new Item("PS5", 4499.90));

      budget2.Amount = budget2.Items.Sum(i => i.Price);

      var discountCalculator = new DiscountCalculator();
      var discount = Math.Round(discountCalculator.Perform(budget2), 2);

      Console.WriteLine(discount);
      //end
    }
  }
}
