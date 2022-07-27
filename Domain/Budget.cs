namespace Dotnet.Design.Patterns.Domain
{
    public class Budget
    {
        public double Amount { get; set; }

        public Budget(double amount)
        {
           this.Amount = amount; 
        }
    }
}