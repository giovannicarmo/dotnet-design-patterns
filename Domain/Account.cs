namespace Dotnet.Design.Patterns.Domain
{
    public class Account
    {
        public double Amount { get; private set; }

        public void Deposit(double value)
        {
            this.Amount += value;
        }
    }
}